# Assignment Info
The purpose of the challenge is to build a smart-cache service that holds a list of breached emails.

# Rationale
A database performance, when it comes to frequent I / O operations, 
represents a bottleneck. In-memory cache, on the other hand, 
is used to avoid this by providing means to access the data from the memory instead.

# Technologies in use:
    • OpenAPI (Swagger.io)
    • Database MSSQL 
    • Application server IIS Express

# Install

## DataBase install
1.Create database "breachedemails" and user "sa" with password "test"
2.Create database table:
```
    CREATE TABLE [dbo].[BreachedeMails]( 
        [Name] [varchar](250) NOT NULL,
		PRIMARY KEY ([Name])
    ) 
```

3.Create sql procedure:	
```
USE [breachedemails]
GO
/****** Object:  StoredProcedure [dbo].[BreachedeMailsFunc]    Script Date: 28. 10. 2021 19:01:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
    ALTER PROCEDURE [dbo].[BreachedeMailsFunc](  
		@Mode           VARCHAR(10), 
        @Email          VARCHAR(250)=   NULL
    )     
    AS  
    BEGIN  
        SET NOCOUNT ON;  
            IF(@Mode='GETALL')  
			BEGIN  
				SELECT   
					Name  
				FROM   
					BreachedeMails  
			END  
			ELSE IF(@Mode='GETBYEMAIL')  
            BEGIN  
                SELECT   
                    Name  
                FROM   
                    BreachedeMails BM  
                WHERE   
                    BM.Name=@Email  
				PRINT 'ok'
            END  
            ELSE IF(@Mode='EDIT')  
            BEGIN  
                IF NOT EXISTS(SELECT 1 FROM BreachedeMails WHERE Name=@Email)  
                BEGIN  
                    INSERT INTO BreachedeMails(  
                        Name  
                        )  
                        VALUES (  
                        @Email  
                        )  
					PRINT 'ok' 
                END  
                ELSE  
                BEGIN  
                    PRINT 'nok' 
                END  
            END  
            ELSE IF(@Mode='DELETE')  
            BEGIN  
                DELETE FROM BreachedeMails WHERE Name=@Email 
            END  
    END  
```

## Application server:

### Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

### Run in Docker

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```

3. On succesfull build open in browser: http://localhost:50352/swagger/index.html
	[localhost swagger](http://localhost:50352/swagger/index.html "localhost swagger")

## Unit test:
To run unit test run TestProject1

## Integartion test:
1. Add email:
```curl -X POST "http://localhost:50352/v2/breachedemails" -H  "accept: */*" -H  "Content-Type: application/json-patch+json" -d "{\"name\":\"janez@test.si\"}"
```
return code 200 - created
return code 400 - conflict
2. Get email
```curl -X GET "http://localhost:50352/v2/breachedemails/janez%40test.si" -H  "accept: */*"
```
return code 200 - OK
return code 400 - NotFound
3. Delete email:
```curl -X DELETE "http://localhost:50352/v2/breachedemails/janez%40test.si" -H  "accept: */*"
```
return code 200 - OK

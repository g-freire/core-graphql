[ ![Build Status](https://travis-ci.org/PierreZ/goStatic.svg?branch=master)](https://travis-ci.org) 
### Financial API modeling using .NET core 2 + GraphQL 
### The server response returns the graph nodes requested by each query
#
### Steps to run:
#
#### Using dotnet core CLI:
```diff
+ $ dotnet restore
+ $ dotnet build
+ $ dotnet run 
```
#
#### you may check the endpoints at http://localhost:3000/  or 
#### query the API using Postman:
#
![Screenshot](graph.PNG)
#
#### The GraphQL architecture design :
- offers the best of both SOAP and REST
- is strongly typed
- uses standard protocols (HTTP)
- generates efficient/modern data payloads
- requires fewer network roundtrips by multiplexing the endpoints
#
#### to learn more about GraphQL: https://graphql.org/




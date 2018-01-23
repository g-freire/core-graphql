# stone-graphql
sandboxing graphql w/ dotnet core 2 and docker

Sample Query using Postmen:

{
 "query":
  "query{
     category(id:1){
       id
       name
       products{
       	id
       	name
       	cardbrand
       	merchantReference
       	mCC

       }
     }
   }"
}

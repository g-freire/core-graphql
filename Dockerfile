# multistage build local 
FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app
# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore
# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY --from=build-env /app/out .
# main dll has same name as .csproj file
ENTRYPOINT ["dotnet", "aspnetcoregraphql.dll"]

LABEL maintainer="gustavomfreire@gmail.com"

#   docker build -t core_graph_img .
#   docker run -d -p 3000:80 --name core_graph_ctn core_graph_img


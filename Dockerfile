FROM mcr.microsoft.com/dotnet/core/sdk:3.0.100-preview8 AS build
WORKDIR /src
COPY BlazorWebApp/ BlazorWebApp/
COPY OpenBlazorLibrary/ OpenBlazorLibrary/
COPY BlazorWebApp.sln .
RUN dotnet restore "BlazorWebApp.sln"
RUN dotnet build "BlazorWebApp.sln" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorWebApp.sln" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/BlazorWebApp/dist .
COPY nginx.conf /etc/nginx/nginx.conf

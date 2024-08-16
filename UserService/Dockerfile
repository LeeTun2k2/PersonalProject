# Base stage with Alpine
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/UserService.API/UserService.API.csproj", "src/UserService.API/"]
COPY ["src/UserService.Application/UserService.Application.csproj", "src/UserService.Application/"]
COPY ["src/UserService.Core/UserService.Core.csproj", "src/UserService.Core/"]
COPY ["src/UserService.Infrastructure/UserService.Infrastructure.csproj", "src/UserService.Infrastructure/"]
RUN dotnet restore "./src/UserService.API/UserService.API.csproj"
COPY . .
WORKDIR "/src/src/UserService.API"
RUN dotnet build "./UserService.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./UserService.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final stage with Alpine
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Environment variables
ENV POSTGRES_HOST=${POSTGRES_HOST}
ENV POSTGRES_PORT=${POSTGRES_PORT}
ENV POSTGRES_USER=${POSTGRES_USER}
ENV POSTGRES_PASSWORD=${POSTGRES_PASSWORD}
ENV POSTGRES_DATABASE=${POSTGRES_DATABASE}
ENV REDIS_HOST=${REDIS_HOST}
ENV REDIS_PORT=${REDIS_PORT}
ENV REDIS_PASSWORD=${REDIS_PASSWORD}
ENV MAIL_DISPLAYNAME=${MAIL_DISPLAYNAME}
ENV MAIL_FROM=${MAIL_FROM}
ENV MAIL_HOST=${MAIL_HOST}
ENV MAIL_PORT=${MAIL_PORT}
ENV MAIL_USERNAME=${MAIL_USERNAME}
ENV MAIL_PASSWORD=${MAIL_PASSWORD}
ENV MAIL_USESSL=${MAIL_USESSL}
ENV MAIL_USESTARTTLS=${MAIL_USESTARTTLS}
ENV JWT_KEY=${JWT_KEY}
ENV JWT_ISSUER=${JWT_ISSUER}
ENV JWT_AUDIENCE=${JWT_AUDIENCE}

# Start application
ENTRYPOINT ["dotnet", "UserService.API.dll"]
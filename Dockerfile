FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["LeetCodeTasks.csproj", "./"]
RUN dotnet restore "LeetCodeTasks.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "LeetCodeTasks.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeetCodeTasks.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LeetCodeTasks.dll"]

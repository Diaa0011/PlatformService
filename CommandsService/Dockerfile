# .NET Core SDK -Parent Image-
FROM mcr.microsoft.com/dotnet/sdk:8.0 As build-env
#every instrcution we use under this directory will be executed in it
WORKDIR /app


# Copy Projects
COPY *.csproj ./
RUN dotnet restore

#copy some files to the image
#first dot meaning hte correct directory second dot is the directory inside the image
COPY . ./
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet","CommandsService.dll"]
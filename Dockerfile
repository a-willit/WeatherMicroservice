FROM microsoft/dotnet:1.1-sdk-msbuild

#ENV http_proxy http://proxy-lmi.global.lmco.com:80/
#ENV https_proxy http://proxy-lmi.global.lmco.com:80/
#ENV no_proxy http://proxy-lmi.global.lmco.com:80/

WORKDIR /app

# copy csproj and restore as distinct layers

COPY WeatherMicroservice.csproj .

COPY NuGet.config /root/.nuget/NuGet/NuGet.Config
RUN chown 777 /root/.nuget/NuGet/NuGet.Config
#RUN echo "start log build process" && sleep 240 && echo "log build process finished"


RUN dotnet restore  --configfile /root/.nuget/NuGet/NuGet.Config

# copy and build everything else

COPY . .

# RUN dotnet restore
RUN dotnet publish -c Release -o out
#ENTRYPOINT ["dotnet", "out/WeatherMicroservice.dll", "--server.urls", "http://127.0.0.1:5000"]
ENTRYPOINT ["dotnet", "out/WeatherMicroservice.dll", "--server.urls", "http://127.0.0.1:1000"]

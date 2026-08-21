# Gunakan image runtime .NET (sesuaikan versi: 8.0 / 7.0 / 6.0)
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app

# Salin seluruh isi folder publish lokal ke dalam image docker
COPY . .

# Konfigurasi port untuk Railway
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

# Jalankan file .dll utama Anda
ENTRYPOINT ["dotnet", "CVSatriaMandiriRepo.dll"]
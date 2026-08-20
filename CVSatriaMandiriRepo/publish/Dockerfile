# Langsung gunakan runtime .NET (tidak perlu SDK compiler lagi)
FROM ://microsoft.com
WORKDIR /app

# Salin seluruh isi folder publish lokal ke dalam image docker
COPY . .

# Konfigurasi port untuk Railway
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

# Jalankan file .dll utama Anda
ENTRYPOINT ["dotnet", "CVSatriaMandiriRepo.dll"]

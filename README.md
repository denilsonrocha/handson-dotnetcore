# My Music Challenge

Creation of an application to search musics and create user playlists

See the [PDF document](MyMusic.NET.pdf) for complete instructions

### Prerequisites

.Net Core 3.1

### Tips

Under database folder the "MyMusic.db" contains a Sqlite relational database
with all data needed to this challenge.

Under src folder contains a sample api consuming the aforementioned database.

### Run api

```
dotnet run -p .\src\Ciandt.Hiring.SampleApi\Ciandt.Hiring.SampleApi.csproj
```

### Make request

```
GET https://localhost:5001/api/sample
```
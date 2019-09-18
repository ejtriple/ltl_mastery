### ltl_mastery

### Overview

Simple ASP.NET Core app using EF Core in-memory database to simulate the "best-fit" heuristic for filling shipping containers.

### Requirements

- .NET Core 2.2 SDK

### How to run

Install the .NET Core SDK found here: https://dotnet.microsoft.com/download


### Testing steps

Run the web app locally
```
cd <path>/LTLMastery.web
dotnet run
```

open a web-browser to https://localhost:5001/swagger

The swagger page exposes two endpoints:

`/api/shipment`

`/api/shipment/results`

shipment will produce the shipments loaded into the in-memory database

shipment/results will run through the best-fit heuristic and produce a json response of the shippign results.

The results contain a list of shipped and unshipped shipments and the capacity for both.

### Further Consideration

- Add additonal endpoints for other common heuristics
- Add endpoints for adding shipments and trucks
- Add ability to save results and reference result set by ID
- Docker-compose support
- Unit test

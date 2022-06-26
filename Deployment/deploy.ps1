$startLocation = Resolve-Path "."
$projectPath = Resolve-Path ".."
$imageName = "randomword"

$serverConfig = Get-Content serverConfig.json | ConvertFrom-Json

Set-Location $projectPath
docker buildx build --platform linux/arm64 --push -t $serverConfig.DockerUsername/$imageName .

plink -ssh $serverConfig.Url -P $serverConfig.Port -l $serverConfig.Username -pw $serverConfig.Password -batch "cd $($serverConfig.ServerDirectory); docker compose pull; docker compose down; docker compose up -d"

Set-Location $startLocation

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

install_autosdk_cli
rm -rf Generated
# OpenAPI spec is manually maintained (no public spec available)
autosdk generate openapi.yaml \
  --namespace HumeAI \
  --clientClassName HumeAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations

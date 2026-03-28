dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
# OpenAPI spec is manually maintained (no public spec available)
autosdk generate openapi.yaml \
  --namespace HumeAI \
  --clientClassName HumeAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations

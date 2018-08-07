#!/usr/bin/env bash
set -ex

dotnet test ./test/auroratests

build_output="/tmp/build-output"
artifacts_path="./artifacts"

mkdir -p $build_output
mkdir -p $artifacts_path

# Deploy to PCF requires manifest files
# cp manifest-*.yml $build_output

dotnet publish src/aurora --configuration Release \
    --output $build_output/src/aurora/bin/Release/netcoreapp2.0/publish

tar -C $build_output/ -cvzf $artifacts_path/aurora-$CIRCLE_SHA1.tgz .
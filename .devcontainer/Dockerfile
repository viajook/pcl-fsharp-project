# ARG VARIANT="6.0"
#FROM mcr.microsoft.com/devcontainers/dotnet:0-${VARIANT}

FROM fsharp:netcore
COPY settings.vscode.json /root/.vscode-remote/data/Machine/settings.json

# Install git, process tools
RUN apt-get update && apt-get -y install git procps
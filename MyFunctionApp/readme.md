# Azure Function App with Azure Cosmos DB

This guide will help you set up an Azure Function App that interacts with Azure Cosmos DB.

## Prerequisites

- An Azure account
- Azure Cosmos DB account
- Azure Functions Core Tools
- Azure CLI
- .NET SDK

## Setting Up Azure Cosmos DB

First, ensure you have an Azure Cosmos DB account set up. You can create one via the [Azure Portal](https://portal.azure.com).

## Creating the Azure Function App

### Step 1: Initialize the Azure Function App

1. **Install Azure Functions Core Tools and Azure CLI** if you haven't already. You can download and install them from the following links:
   - [Azure Functions Core Tools](https://docs.microsoft.com/azure/azure-functions/functions-run-local#v2)
   - [Azure CLI](https://docs.microsoft.com/cli/azure/install-azure-cli)

2. **Initialize a new Function App:**
   ```bash
   func init MyFunctionApp --worker-runtime dotnet
   cd MyFunctionApp

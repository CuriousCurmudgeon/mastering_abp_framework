﻿namespace ProductManagement.Data;

public interface IProductManagementDbSchemaMigrator
{
    Task MigrateAsync();
}

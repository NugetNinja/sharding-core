﻿using Microsoft.EntityFrameworkCore;
using ShardingCore.Sharding.Abstractions;
using System;

namespace ShardingCore.DynamicDataSources
{
    public class DynamicDataSourceHelper
    {
        private DynamicDataSourceHelper()
        {
            throw new InvalidOperationException($"{nameof(DynamicDataSourceHelper)} create instance");
        }

        public static void DynamicAppendDataSource<TShardingDbContext>(string dataSourceName, string connectionString) where TShardingDbContext:DbContext,IShardingDbContext
        {
            var defaultDataSourceInitializer = ShardingContainer.GetService<IDefaultDataSourceInitializer<TShardingDbContext>>();
            defaultDataSourceInitializer.InitConfigure(dataSourceName, connectionString);
        }

    }
}

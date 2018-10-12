using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Aticms.Utils
{
    public static class appSetting
    {
        public static string GetConfig(string nodeName)
        {
            //添加 json 文件路径
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            //创建配置根对象
            var configurationRoot = builder.Build();

            return configurationRoot[nodeName];
        }

    }
}

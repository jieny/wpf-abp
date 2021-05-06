﻿namespace Consumption.ViewModel.Common
{
    using Microsoft.Toolkit.Mvvm.ComponentModel;

    /// <summary>
    /// 模块
    /// </summary>
    public class Module : ObservableObject
    {
        private string code;
        private string name;
        private int auth;
        private string typeName;

        /// <summary>
        /// 模块图标代码
        /// </summary>
        public string Code
        {
            get { return code; }
            set { code = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 模块名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 模块命名空间
        /// </summary>
        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 权限值
        /// </summary>
        public int Auth
        {
            get { return auth; }
            set { auth = value; OnPropertyChanged(); }
        }
    }

    /// <summary>
    /// 模块UI组件
    /// </summary>
    public class ModuleUIComponent : Module
    {
        private object body;

        /// <summary>
        /// 页面内容
        /// </summary>
        public object Body
        {
            get { return body; }
            set { body = value; OnPropertyChanged(); }
        }
    }
}

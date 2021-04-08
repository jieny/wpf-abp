﻿/*
*
* 文件名    ：BaseViewModel                             
* 程序说明  : MVVM基类
* 更新时间  : 2020-05-30 14：27
* 联系作者  : QQ:779149549 
* 开发者群  : QQ群:874752819
* 邮件联系  : zhouhaogg789@outlook.com
* 视频教程  : https://space.bilibili.com/32497462
* 博客地址  : https://www.cnblogs.com/zh7791/
* 项目地址  : https://github.com/HenJigg/WPF-Xamarin-Blazor-Examples
* 项目说明  : 以上所有代码均属开源免费使用,禁止个人行为出售本项目源代码
*/



namespace Consumption.ViewModel
{
    using Microsoft.Toolkit.Mvvm.ComponentModel;
    using Microsoft.Toolkit.Mvvm.Input;
    using Microsoft.Toolkit.Mvvm.Messaging;
    using System;

    /// <summary>
    /// MVVM基类
    /// </summary>
    public class BaseDialogViewModel : ObservableObject
    {
        public BaseDialogViewModel()
        {
            ExecuteCommand = new RelayCommand<string>(Execute);
        }

        public virtual void Execute(string arg)
        {
            switch (arg)
            {
                case "关闭": WeakReferenceMessenger.Default.Send("", "Exit"); break;
            }
        }

        public RelayCommand<string> ExecuteCommand { get; private set; }

        private bool isOpen;

        /// <summary>
        /// 窗口是否显示
        /// </summary>
        public bool DialogIsOpen
        {
            get { return isOpen; }
            set { isOpen = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// 通知异常
        /// </summary>
        /// <param name="msg"></param>
        public virtual void SnackBar(string msg)
        {
            WeakReferenceMessenger.Default.Send(msg, "Snackbar");
        }
    }
}

﻿using FuckTencentMeeting;
using System.Diagnostics;
using WindowsInput;

Console.WriteLine("输入一下会议号？ ");
string code = Console.ReadLine(); //会议号
Console.WriteLine("输入一下会议密码？ ");
string passwd = Console.ReadLine(); //会议密码
Console.WriteLine("输入一下预定时间？(天/小时/分钟) 格式：日期/小时/分钟 ");
string now = Console.ReadLine(); //预定时间

var dateTime = DateTime.Now.ToString("dd/H/m");

while (true)
{
    dateTime = DateTime.Now.ToString("dd/H/m");

    if (now == dateTime)
    {
        Console.WriteLine($"已经到达指定时间({now})，正在启动腾讯会议");
        Start(code);
        break;
    }
}

void Start(string code)
{
    //这里改成自己的安装路径
    Process.Start(@"C:\Program Files (x86)\Tencent\WeMeet\wemeetapp.exe");
    Thread.Sleep(3800);

    Win32Method.LeftMouseClick(820, 319);
    Thread.Sleep(500);

    new InputSimulator().Keyboard.TextEntry(code);
    Thread.Sleep(500);

    Win32Method.LeftMouseClick(959, 813);
    Thread.Sleep(1000);

    new InputSimulator().Keyboard.TextEntry(passwd);
    Thread.Sleep(500);

    Win32Method.LeftMouseClick(1002, 582);
    Console.WriteLine("入会成功了吧");
}
﻿// See https://aka.ms/new-console-template for more information
using static test_SOLID.OCP;

Console.WriteLine("Hello, World!");

/*
 * SOLID 指導原則
 * S (Single Responsibility Principle): 單一責任原則 SRP
 * O (Open Closed Principle): 開放封閉原則 OCP
 * L (Liskov Substitution Principle): 里氏替換原則 LSP
 * I (Interface Segregation Principle): 介面隔離原則 ISP
 * D (Dependence Inversion Principle): 相依反轉原則 DIP
 */

// OCP Demo
CallOCP demo = new CallOCP();
demo.RunDemoOCP();
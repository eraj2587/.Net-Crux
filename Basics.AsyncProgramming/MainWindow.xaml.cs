using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Basics.AsyncProgramming
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //TODO : Update text immediately without waiting for 2 sec
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Task.Delay(2000);
        //    LoginText.Content = "Login Successful";
        //}

        //TODO : Update text immediately without waiting for 2 sec NOTE : await missing
        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Task.Delay(2000);
        //    LoginText.Content = "Login Successful";
        //}

        //TODO : calls after 2 seconds : Run directly on UI thread
        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{
        //   await Task.Delay(2000);
        //    LoginText.Content = "Login Successful";
        //}

        //TODO : Run async operation in different thread instead of UI thred
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = Task.Run(() =>
           {
               Task.Delay(2000);
               return "Login Successful";
           });

            LoginText.Content = result.Result;
        }

        ///*
        //TODO : SMOOTH EXECUTION
        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //TODO : Run immidiately and not waiting for 2 seconds with below 3 different implmentation
        //    //LoginText.Content = GetLoginTextAsync_V2().Result; //TODO : With Deadlock as thread is same as UI
        //    //LoginText.Content = await GetLoginTextAsync_V2(); // TODO:Smooth
        //    LoginText.Content = Task.Run(() => { return GetLoginTextAsync_V1(); }).Result;
        //    // LoginText.Content =  GetLoginTextAsync().Result;
        //    //TODO : Waiting for 2 seconds
        //    //LoginText.Content = Task.Run(async () => { return await GetLoginTextAsync_V1(); }).Result;
        //    //TODO: await gives content directly, without await will give Task Object
        //    //LoginText.Content =await GetLoginTextAsync_V2();  
        //}
        //*/
        //TODO : DEADLOCK
        /*    private  void Button_Click(object sender, RoutedEventArgs e)
             {
                 LoginText.Content = GetLoginTextAsync_V2().Result;
             }
        */
        private async Task<string> GetLoginTextAsync_V2()
        {
           await Task.Delay(2000);
            return "Login attempted";
        }

        private async Task<string> GetLoginTextAsync_V1()
        {
            Task.Delay(2000);
            return  "Login attempted";
        }

      
    }
}

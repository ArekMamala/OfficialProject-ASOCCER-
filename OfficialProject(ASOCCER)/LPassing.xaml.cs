using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using Windows.UI.Popups;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace OfficialProject_ASOCCER_
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LPassing : Page
    {
        public LPassing()
        {
            this.InitializeComponent();
        }

        //for home button
        private void Home(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(StartPage), null);

        }

        //saving the text from the comments and username
        private async void testSave(object sender, RoutedEventArgs e)
        {
            //creating strings for file comments and username
            String fileName = "Comments1.txt";
            String text = "COMMENT-> " + commentTxt.Text + Environment.NewLine;
            String textUser = Environment.NewLine + "USERNAME-> " + commentTxt1.Text + Environment.NewLine;

            Windows.Storage.StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile file = await localFolder.GetFileAsync(fileName);

            //appending the file
            await FileIO.AppendTextAsync(file, textUser);
            await FileIO.AppendTextAsync(file, text);
        }//end of testsave

        //loading comments from file on to a textblock 
        private async void loadComments(object sender, RoutedEventArgs e)
        {
            //creating 2 strings the file name and text for the empty textblock
            String fileName = "Comments1.txt";
            String textIn = commentsIn.Text;
            StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;

            //try catch if the file doesent exist
            try
            {
                //change the text in the file to the textblock
                StorageFile file = await localFolder.GetFileAsync(fileName);
                String text = await FileIO.ReadTextAsync(file);
                commentsIn.Text = text;
            }
            catch (Exception)
            {
                //send out  amessage if the file doest exist
                MessageDialog md = new MessageDialog("File doesnt exist" + fileName);
                await md.ShowAsync();
            }
        }//end of load comments 
    }
}
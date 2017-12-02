using System;

namespace NoteBookProject
{
    public class WriteNotesToFileCommand : ICommand
    {
        private NoteBookProvider receiver;

        public  WriteNotesToFileCommand()
        {
            receiver = NoteBookProvider.GetProvider();
        }

        public void Execute()
        {
            receiver.WriteNotesToFile(Console.ReadLine());
        }
    }
}

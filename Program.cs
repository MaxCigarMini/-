using Console_project.Model;
using Console_project.Repository;
using System.Threading.Channels;

namespace Console_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            NoteService noteService = new NoteService();

            while (true)
            {

            }
            try
            {
                User user1 = userService.Registration("Vitalik");
            }
            catch (Exception ex) { Console.WriteLine($"Ошибка регистрации: {ex.Message}"); };
        }
    }
}

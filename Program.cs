using System;

namespace Д.з_6_Alif__30._01_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите ключь: ");
            string key = Console.ReadLine();

            DocumentWorker docfree = new DocumentWorker();

            ProDocumentWorker prodoc = new ProDocumentWorker();

            ExpertDocumentWorker expertdoc = new ExpertDocumentWorker();


            switch (key)
            {
                case "pro":
                    prodoc.EditDocument();
                    prodoc.SaveDocument();
                    break;
                case "exp":
                    expertdoc.SaveDocument();
                    break;
                default:
                    docfree.OpenDocument();
                    docfree.EditDocument();
                    docfree.SaveDocument();
                    break;
            }
        }
    }

    public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }


        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }


    public class ProDocumentWorker: DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }

    }

    public class ExpertDocumentWorker: ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}

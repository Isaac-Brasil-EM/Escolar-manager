using System;

public class ClasseGenerica<T>
{
    public string MostraLista(List<T> pessoas)
    {
        if (pessoas.Count > 0)
        {
            int i = 0;
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine((i + 1) + "-" + pessoa);
                i++;
            }
            Console.WriteLine("");

            return pessoas.ToString();
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Nenhuma pessoa cadastrada.");
            Console.ResetColor();
            return "";
        }

    }
    public void DeletaPessoa(List<T> pessoas, int indexPessoa)
    {

        if (indexPessoa > 0 && pessoas.Count > 0 && indexPessoa <= pessoas.Count) // se a lista não for vazia, limpa ela no indice indexProf
        {
            pessoas.RemoveAt((indexPessoa - 1));
        }
        else if (indexPessoa <= 0 || indexPessoa > pessoas.Count)
        {

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Insira um índice válido!");
            Console.ResetColor();

        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Nenhuma pessoa cadastrada.");
            Console.ResetColor();

        }


    }
}



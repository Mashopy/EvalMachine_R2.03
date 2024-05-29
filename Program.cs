Console.WriteLine("Saisir la taille du tableau:");
int taille = Convert.ToInt32(Console.ReadLine());

int[] T = TableauEntier(taille);

static int[] TableauEntier(int taille)
{
    int[] T = new int[taille];

    for (int i = 0; i < T.Length; i++)
    {
        Console.WriteLine($"Saisir l'élément {i}:");
        T[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    return T;
}

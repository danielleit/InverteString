string palavraParaTeste = "paralelepipedo";

char[] arrayDeChar = palavraParaTeste.ToCharArray();

string textoInvertido = "";

for (int i = arrayDeChar.Length - 1; i >= 0; i--) {
    textoInvertido += arrayDeChar[i];
}

Console.WriteLine(textoInvertido);
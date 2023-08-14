using System.Text;

string code = "T4 l16 _36 510 _27 s26 _11 320 414 {6 }39 C2 T0 m28 317 y35" +
                " d31 F1 m22 g19 d38 z34 423 l15 329 c12 ;37 19 h13 _30 F5" +
                " t7 C3 325 z33 _21 h8 n18 132 k24";

string[] split = code.Split(" ");

StringBuilder placement = new StringBuilder(split.Length);

for (int i = 0; i <= split.Length; i++)
{
    placement.Append('*');
}

foreach (var item in split)
{
    char letter = item[0];
    int index = 0;
    Int32.TryParse(item.Substring(1), out index);
    placement[index] = letter;
}

Console.WriteLine(placement);
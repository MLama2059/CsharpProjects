double value = 1000D / 12.34D;

Console.WriteLine(value);
Console.WriteLine(string.Format("{0:0}", value));
Console.WriteLine(string.Format("{0:0.0}", value));
Console.WriteLine(string.Format("{0:0.00}", value));
Console.WriteLine(string.Format("{0:0.#}", value));

double money = -10D / 3D;

Console.WriteLine(money);
Console.WriteLine(string.Format("-£10 / £3 = £{0:0.00}", money));
Console.WriteLine(money.ToString("C"));
Console.WriteLine(money.ToString("C0"));
Console.WriteLine(money.ToString("C1"));
Console.WriteLine(money.ToString("C2"));
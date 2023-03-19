using TP_MOD5_1302210094;

String Nama = Console.ReadLine();
HaloGeneric hg = new HaloGeneric();
hg.SapaUser(Nama);

DataGeneric<String> dg = new DataGeneric<String>("1302210084");
dg.PrintData();
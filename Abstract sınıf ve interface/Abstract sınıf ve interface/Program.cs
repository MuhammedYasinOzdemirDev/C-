using Abstract_sınıf_ve_interface;

Sekil[] sekiller = new Sekil[3];
sekiller[0] = new Daire(4, 5);
sekiller[1]=new Ucgen(6, 7);
sekiller[2]=new Kare(8, 9);
sekiller[0].Draw();
sekiller[1].Draw();
sekiller[2].Draw();
IPersonel[] personels = new IPersonel[2];
personels[0] = new Yönetici("Muhammed Yasin","CEO");
personels[1] = new Isci("Eyup","IT");
personels[0].Bilgi();
personels[1].Bilgi();
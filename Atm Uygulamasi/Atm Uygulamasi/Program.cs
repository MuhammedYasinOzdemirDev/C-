using Atm_Uygulamasi;

Hesap hesap = new Hesap("kkyyasin", "12345", 5000);
Atm atm = new Atm();
atm.hesap = hesap;
atm.calis();

class body ():
    def name():
        print("Tere! Olen sinu uus sõber - Python!")

        while 1:
            try:
                global nimi
                nimi = input("Sinu nimi on ? ")
                if nimi.isalpha() == True:
                    break
                else:
                    continue
            except TypeError:
                continue
        
        print(nimi+", oi kui ilus nimi!")

    def prog():
        if start == "1":
            while 1:
                try:
                    pikkus = float(input(nimi + " Sinu pikkus (cm) => "))
                    break
                except ValueError:
                    continue
            while 1:
                try:
                    mass = float(input("Anna kaal ka (kg) => "))
                    break
                except ValueError:
                    continue
            indeks = mass / (0.01 * pikkus)**2
            indeks = str(int(indeks))
            print("Sinu keha indeks on: "+indeks)
            indeks = int(indeks)
            if indeks < 16:
                print("Tervisele ohtlik alakaal")
            elif indeks > 16 and indeks < 20:
                print("Alakaal")
            elif indeks > 19 and indeks < 26:
                print("Normaalkaal")
            elif indeks > 25 and indeks < 31:
                print("Ülekaal")
            elif indeks > 30 and indeks < 36:
                print("Rasvumine")
            elif indeks > 35 and indeks < 41:
                print("Tugev rasvumine")
            elif indeks > 40:
                print("Tervisele ohtlik rasvumine")
        else start == "0":
            print(":(")
    name()
    global start
    start = input("Kas leian Sinu keha indeksi? 0-ei, 1-jah => ")
    prog()

    


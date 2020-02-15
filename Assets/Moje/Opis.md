Co zostało zrobione przeze mnie?

> Cała muzyka i dźwięki są z freesound.

- Ambient grający w tle.
- Dźwięk trawy przy chodzeniu.
- Dźwięk hop przy skakaniu
- Dźwięki wiatraka (3D), którego szybkość odtwarzania (Pitch) zależy od szybkości kręcenia się.
- Wszystko połączone przy użyciu AudioMixer

- Co się ze sobą kłóci, ale Menu:
	- korzysta ze Snapshotów do zmian dźwięków kiedy jest aktywne
		- Wykorzystanie efektu Lowpass na Ambient.
	- Użycie ExposedVariable do zmiany ustawień gracza
		- Master
		- Music
		- Character
		- Enviroment
	- Obliczanie decybeli przy użyciu wzoru `20f * log(value)`
	- Zapis i odczyt z PlayerPrefs
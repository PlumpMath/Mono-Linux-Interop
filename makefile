all:
	cd Factorial.Library && $(MAKE)
	cd Factorial.Console && $(MAKE)
	
clean:
	cd Factorial.Console && $(MAKE) clean
	cd Factorial.Library && $(MAKE) clean


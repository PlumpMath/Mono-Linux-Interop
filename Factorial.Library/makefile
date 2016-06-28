all: link_shared

comp: 
	gcc -c -Wall -O2 -fpic fact.c

link_shared: comp
	gcc -shared -o libfact.so fact.o
	cp libfact.so /usr/local/lib
	
clean:
	rm -f /usr/local/lib/libfact.so
	rm -f fact.o
	rm -f libfact.so


Kompleksitas waktu dari implementasi ini adalah O(n), 
di mana n adalah panjang input (jumlah karakter dalam string bracket). 
Ini karena kita hanya melalui string bracket satu kali, 
dan setiap operasi push atau pop pada stack memiliki kompleksitas waktu O(1).

Kompleksitas ruang adalah O(m), 
di mana m adalah jumlah karakter yang merupakan 
bracket buka (opening brackets) dalam string input. 
Hal ini karena stack hanya menyimpan bracket buka, 
dan pada kondisi terburuk, semua karakter input adalah bracket buka.
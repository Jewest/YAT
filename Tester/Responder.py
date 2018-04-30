#!/usr/bin/env python
# -*- coding: utf-8 -*-
#
# Copyright 2018 Jeffrey Westgeest
#
# This program is free software; you can redistribute it and/or modify
# it under the terms of the GNU General Public License as published by
# the Free Software Foundation; either version 2 of the License, or
# (at your option) any later version.
#
# This program is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
# GNU General Public License for more details.
#
# You should have received a copy of the GNU General Public License
# along with this program; if not, see <http://www.gnu.org/licenses/>.

# remarks
#tested with python 3.6
#ensure to install pyserial.
import serial
from serial.tools import list_ports



def print_serial_ports():

    # produce a list of all serial ports. The list contains a tuple with the port number, 
    # description and hardware address
    #
	print("###Scanning ports.###")
	ports = list(serial.tools.list_ports.comports())  

    #print all the info
	for port_no, description, address in ports:
		print(port_no)

	print("###Scanning ports.###")
	
def main():

	ans=True
	while ans:
		#make the menu structure
		print("""
		L. List the serial ports.
		Q. Quite
		""")
		ans=input("What would you like to do? ")
		if ans == "L":
			print_serial_ports()
		elif ans == "Q":
			ans = None
		else:
			print("\n Not Valid Choice Try again")
	
			

if __name__ == "__main__":
	print("running tester version 0.0.1")
	main()
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
import os
import time

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

def clear_terminal():
	os.system('cls')  # assuming windows
	
def run_responder():
	clear_terminal()
	#running the responder, as for the port.
	port=input("Which comport?")
	if(port.isnumeric()):
		#try an open the serial port
		ser = serial.Serial('COM' + port)  # open serial port
		
		if(ser.isOpen()):
			#never ending loop, at the moment
			while 1:
				if(ser.inWaiting() > 0):
					#read one char back and reply
					readData = ser.read()
					print(readData)					
					ser.write(readData)
				else:
					#sleep for a while
					time.sleep(0.1)
				
			ser.close()             # close port
		else:
			print("Unable to open port")
		
		
		
	
	
def main():
	ans=True
	#loop till Q
	while ans:		
		#make the menu structure
		print("""
		L. List the serial ports.
		R. Run the responder
		Q. Quite
		""")
		ans=input("What would you like to do? ")
		if ans == "L":
			print_serial_ports()
		elif ans == "Q":
			ans = None
		elif ans == "R":
			run_responder()
		else:
			print("\n Not Valid Choice Try again")
	
			

if __name__ == "__main__":
	print("running tester version 0.0.1")
	main()
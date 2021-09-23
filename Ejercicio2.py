# -*- coding: utf-8 -*-
"""
Created on Mon Sep 20 20:07:48 2021

@author: hp
"""

from pyswip import Prolog
prolog = Prolog()
prolog.consult("prueba.pl")

print('Juan es hermano de Marcela?')
print(bool(list(prolog.query('hermanode(juan, marcela)'))))

print('Juan es hermano de Carlos?')
print(bool(list(prolog.query('hermanode(carlos, juan)'))))

print('Pablo es abuelo de Maria?')
print(bool(list(prolog.query('abuelode(pablo, maria)'))))

print('Maria es abuela de pablo?')
print(bool(list(prolog.query('abuelode(maria, maria)'))))


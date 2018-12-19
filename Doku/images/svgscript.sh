#!/bin/bash

if [[ $# = 1 ]]; then
  cd $1
fi


for f in *.svg
do
   inkscape --without-gui --file=$f --export-pdf=$(echo $f| cut -d'.' -f 1).pdf
done

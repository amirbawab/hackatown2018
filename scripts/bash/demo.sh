#!/bin/bash

cp ../python/code.py ../../model/research/object_detection/
cd ../models/research/ && protoc object_detection/protos/*.proto --python_out=.
echo "Now navigate to .././model/research/object_detection and run 'python code.py'"

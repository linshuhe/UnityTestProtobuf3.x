echo off
set SRC_DIR=protos
set PWD=%cd%
set DST_DIR=..\Assets\Scripts\ProtoGen

protoc -I=%SRC_DIR% --csharp_out=%DST_DIR% %SRC_DIR%\test.proto

pause
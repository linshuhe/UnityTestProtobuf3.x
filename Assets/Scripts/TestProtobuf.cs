using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using Google.Protobuf;

public class TestProtobuf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Tutorial.Person person = new Tutorial.Person();
        person.Email = "xxxxxxxxx@qq.com";
        person.Id = 666;
        person.Name = "linsh";
        Tutorial.PhoneNumber phoneNum = new Tutorial.PhoneNumber();
        phoneNum.Number = "555-4321"; 
        phoneNum.Type = Tutorial.PhoneType.Home;
        person.Phones.Add(phoneNum);

        // 序列化
        byte[] buff;
        MemoryStream stream = new MemoryStream();
        // Save the person to a stream
        person.WriteTo(stream);
        buff = stream.ToArray();

        // 反序列化
        Tutorial.Person person1 = Tutorial.Person.Parser.ParseFrom(buff);
        Debug.LogFormat("person info =  Email = {0}, Name = {1}, Id = {2} , Phones[0].Number = {3}", 
            person1.Email, person1.Name, person1.Id, person1.Phones[0].Number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

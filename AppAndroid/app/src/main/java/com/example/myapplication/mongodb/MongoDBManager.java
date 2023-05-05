package com.example.myapplication.mongodb;

import android.annotation.SuppressLint;
import com.mongodb.client.MongoClient;
import com.mongodb.client.MongoClients;

public class MongoDBManager {
    private static MongoClient mongoClient;
    @SuppressLint("AuthLeak")
    private static final String MONGODB_CONNECTION_STRING = "mongodb+srv://lyphamvjit1201:Litdethuong010201@cluster0.skwgqxq.mongodb.net";

    public static synchronized MongoClient getMongoClient() {
        if (mongoClient == null) {
            mongoClient = MongoClients.create(MONGODB_CONNECTION_STRING);
        }
        return mongoClient;
    }
}

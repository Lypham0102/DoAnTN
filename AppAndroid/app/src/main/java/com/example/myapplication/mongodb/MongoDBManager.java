package com.example.myapplication.mongodb;

import static com.mongodb.client.model.Filters.eq;
import com.example.myapplication.models.NhanVienModels;
import com.mongodb.MongoClient;
import com.mongodb.MongoClientURI;
import com.mongodb.client.MongoCollection;
import com.mongodb.client.MongoDatabase;
import org.bson.Document;

public class MongoDBManager {
    private static final String DATABASE_NAME = "TrangTrai";
    private static final String MONGODB_URI = "mongodb+srv://lyphamvjit1201:Litdethuong010201@cluster0.skwgqxq.mongodb.net/test";
    private static MongoClient mongoClient;
    private static MongoDatabase mongoDatabase;

    public static void connect() {
        MongoClientURI uri = new MongoClientURI(MONGODB_URI);
        mongoClient = new MongoClient(uri);
        mongoDatabase = mongoClient.getDatabase(DATABASE_NAME);
    }
    public static void disconnect() {
        mongoClient.close();
    }
    public static MongoCollection getCollection(String collectionName) {
        return mongoDatabase.getCollection(collectionName);
    }
    public static NhanVienModels authenticateUser(String username, String password) {
        MongoCollection<Document> nhanVienCollection = getCollection("NhanVien");
        Document nhanVienDocument = nhanVienCollection.find(eq("TenTaiKhoan", username)).first();
        if (nhanVienDocument == null) {
            return null;
        }
        NhanVienModels nhanVien = new NhanVienModels();
        nhanVien.setTenTaiKhoan(nhanVienDocument.getString("TenTaiKhoan"));
        nhanVien.setPasswork(nhanVienDocument.getString("Passwork"));

        return nhanVien;
    }
}

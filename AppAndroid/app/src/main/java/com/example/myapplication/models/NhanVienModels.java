package com.example.myapplication.models;
import org.bson.types.ObjectId;

public class NhanVienModels {
    private ObjectId _id;
    private String MaNV;
    private String TenNV;
    private String CCCD;
    private String SDT;
    private String DiaChi;
    private String MaNT;
    private String TenTaiKhoan;
    private String Passwork;
    private String ChucVu;
    private String HeSoLuong;
    private String NganHang;
    private String STK;
    private String _idNongTrai;
    private String MaNongTrai;

    public NhanVienModels() {
        this._id = new ObjectId();
        this.MaNV = MaNV;
        this.TenNV = TenNV;
        this.CCCD = CCCD;
        this.SDT = SDT;
        this.DiaChi = DiaChi;
        this.MaNT = MaNT;
        this.TenTaiKhoan = TenTaiKhoan;
        this.Passwork = Passwork;
        this.ChucVu = ChucVu;
        this.HeSoLuong = HeSoLuong;
        this.NganHang = NganHang;
        this.STK = STK;
        this._idNongTrai = _idNongTrai;
        this.MaNongTrai = MaNongTrai;

    }//get set methods
    public ObjectId get_id() {return this._id;}
    public void set_id (ObjectId _id) {this._id = _id;}
    public String getMaNV() {return this.MaNV;}
    public void setMaNV(String MaNV) {this.MaNV = MaNV;}
    public String getTenNV() {return this.TenNV;}
    public void setTenNV(String MaNV) {this.TenNV = TenNV;}
    public String getCCCD() {return this.CCCD;}
    public void setCCCD(String CCCD) {this.CCCD = CCCD;}
    public String getSDT() {return this.SDT;}
    public void setSDT(String SDT) {this.SDT = SDT;}
    public String getDiaChi() {return this.DiaChi;}
    public void setDiaChi (String DiaChi) {this.DiaChi = DiaChi;}
    public String getMaNT() {return this.MaNT;}
    public void setMaNT (String MaNT) {this.MaNT = MaNT;}
    public String getTenTaiKhoan() {return this.TenTaiKhoan;}
    public void setTenTaiKhoan (String TenTaiKhoan) {this.TenTaiKhoan = TenTaiKhoan;}
    public String getPasswork() {return this.Passwork;}
    public void setPasswork (String Passwork) {this.Passwork = Passwork;}
    public String getChucVu() {return this.ChucVu;}
    public void setChucVu (String _id) {this.ChucVu = ChucVu;}
    public String getHeSoLuong() {return this.HeSoLuong;}
    public void setHeSoLuong (String HeSoLuong) {this.HeSoLuong = HeSoLuong;}
    public String getNganHang() {return this.NganHang;}
    public void setNganHang (String NganHang) {this.NganHang = NganHang;}
    public String getSTK() {return this.STK;}
    public void setSTK (String STK) {this.STK = STK;}
    public String get_idNongTrai() {return this._idNongTrai;}
    public void set_idNongTrai (String _idNongTrai) {this._idNongTrai = _idNongTrai;}
    public String getMaNongTrai() {return this.MaNongTrai;}
    public void setMaNongTrai (String MaNongTrai) {this.MaNongTrai = MaNongTrai;}

}

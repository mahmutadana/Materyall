-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost
-- Üretim Zamanı: 13 May 2022, 20:09:17
-- Sunucu sürümü: 5.7.15-log
-- PHP Sürümü: 5.6.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `materyall2022`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `odemeler_tbl`
--

CREATE TABLE `odemeler_tbl` (
  `id` int(11) NOT NULL,
  `oid` int(11) NOT NULL,
  `odemekodu` int(8) NOT NULL,
  `tutar` double NOT NULL,
  `aciklama` varchar(256) COLLATE utf8_turkish_ci NOT NULL,
  `otomatiktarih` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `odemetarihi` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_anadersleroto_tbl`
--

CREATE TABLE `sis_anadersleroto_tbl` (
  `id` int(11) NOT NULL,
  `sinif` int(2) NOT NULL,
  `dersid` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci COMMENT='Ana dersleri ekle düğmesi için.';

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_bayiler_tbl`
--

CREATE TABLE `sis_bayiler_tbl` (
  `id` int(11) NOT NULL,
  `bayikodu` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `bayiadi` varchar(32) COLLATE utf8_turkish_ci NOT NULL,
  `iladi` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `ilceadi` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `ucretgrubu` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_bayiler_tbl`
--

INSERT INTO `sis_bayiler_tbl` (`id`, `bayikodu`, `bayiadi`, `iladi`, `ilceadi`, `ucretgrubu`) VALUES
(1, '388', ' ER_YAYIN', 'GAZIANTEP', 'Şahinbey', 1),
(2, 'ER-1019', 'ER-ADIYAMAN-Gölbaşı-EDE', 'ADIYAMAN', 'Gölbaşı', 2),
(3, 'B-6-1', 'ER-ANKARA-Yenimahalle-BERKAY', 'ANKARA', 'Yenimahalle', 5),
(4, 'B-1085', 'ER-ANKARA-Mamak-MERİÇ', 'ANKARA', 'Mamak', 6),
(5, 'B-1085-1', 'ER-ANKARA-Mamak-GÜL', 'ANKARA', 'Mamak', 6),
(6, 'ER-1083', 'ER-ANKARA-Keçiören-SERKAN', 'ANKARA', 'Keçiören', 2),
(7, 'ER-1087', 'ER-ANKARA-Polatlı-DOĞANŞAR', 'ANKARA', 'Polatlı', 2),
(8, 'ER-1145', 'ER-BALIKESİR-Altıeylül-ALTI EYLÜ', 'BALIKESİR', 'Altıeylül', 2),
(9, 'ER-1159', 'ER-BALIKESİR-Karesi-MERKEZ', 'BALIKESİR', 'Karesi', 2),
(10, 'ER-1227', 'ER-BURSA-İnegöl-DOSTLAR', 'BURSA', 'İnegöl', 2),
(11, 'ER-1227-1', 'ER-BURSA-İnegöl-PLENTY', 'BURSA', 'İnegöl', 2),
(12, 'ER-1229', 'ER-BURSA-Karacabey-KÜLTÜR', 'BURSA', 'Karacabey', 2),
(13, 'ER-1232', 'ER-BURSA-Mudanya-MUDANYA', 'BURSA', 'Mudanya', 2),
(14, 'ER-1233', 'ER-BURSA-Mustafakemalpaşa-ANTARE', 'BURSA', 'Mustafakemalpaşa', 2),
(15, 'ER-1234', 'ER-BURSA-Nilüfer-ETKİN', 'BURSA', 'Nilüfer', 2),
(16, 'ER-1237', 'ER-BURSA-Osmangazi-ERTURAN', 'BURSA', 'Osmangazi', 2),
(17, 'ER-1239', 'ER-BURSA-Yıldırım-ÜNİTE', 'BURSA', 'Yıldırım', 3),
(18, 'ER-1384', 'ER-ESKİŞEHİR-Odunpazarı-KAHRAMAN', 'ESKİŞEHİR', 'Odunpazarı', 2),
(19, 'ER-1384-1', 'ER-ESKİŞEHİR-Odunpazarı-GÜVEN', 'ESKİŞEHİR', 'Odunpazarı', 2),
(20, 'ER-1384-2', 'ER-ESKİŞEHİR-Odunpazarı-KAYNAK', 'ESKİŞEHİR', 'Odunpazarı', 2),
(21, 'ER-1384-3', 'ER-ESKİŞEHİR-Odunpazarı-PETEK', 'ESKİŞEHİR', 'Odunpazarı', 2),
(22, 'ER-1388', 'ER-ESKİŞEHİR-Tepebaşı-ATAK', 'ESKİŞEHİR', 'Tepebaşı', 2),
(23, 'ER-1485', 'ER-İSTANBUL-Küçükçekmece-İLKOKUL', 'İSTANBUL', 'Küçükçekmece', 2),
(24, 'ER-1490', 'ER-İSTANBUL-Silivri-OZAN', 'İSTANBUL', 'Silivri', 2),
(25, 'ER-1524', 'ER-İZMİR-Ödemiş-KİPA', 'İZMİR', 'Ödemiş', 2),
(26, 'ER-1524-1', 'ER-İZMİR-Ödemiş-EROL', 'İZMİR', 'Ödemiş', 2),
(27, 'ER-1524-2', 'ER-İZMİR-Ödemiş-Fİ', 'İZMİR', 'Ödemiş', 2),
(28, 'ER-1536', 'ER-KAHRAMANMARAŞ-Elbistan-IŞIK', 'KAHRAMANMARAŞ', 'Elbistan', 2),
(29, 'ER-1539', 'ER-KAHRAMANMARAŞ-Onikişubat-TANI', 'KAHRAMANMARAŞ', 'Onikişubat', 2),
(30, 'ER-1589', 'ER-KAYSERİ-Kocasinan-BÜRHAN', 'KAYSERİ', 'Kocasinan', 2),
(31, 'ER-1621', 'ER-KIRŞEHİR-Merkez-AHİ', 'KIRŞEHİR', 'Merkez', 2),
(32, 'ER-1621-1', 'ER-KIRŞEHİR-Merkez-ALTIN', 'KIRŞEHİR', 'Merkez', 2),
(33, 'ER-1624', 'ER-KİLİS-Merkez-BEYOĞLU', 'KİLİS', 'Merkez', 2),
(34, 'ER-1664', 'ER-KONYA-Meram-TOSUNLAR', 'KONYA', 'Meram', 2),
(35, 'ER-1680', 'ER-KÜTAHYA-Merkez-ZİRVE', 'KÜTAHYA', 'Merkez', 2),
(36, 'ER-1684', 'ER-KÜTAHYA-Tavşanlı-BİRKARIŞ', 'KÜTAHYA', 'Tavşanlı', 2),
(37, 'ER-1714', 'ER-MANİSA-Şehzadeler-MUTLU', 'MANİSA', 'Şehzadeler', 2),
(38, 'ER-1738', 'ER-MERSİN-Silifke-ÖZGÜN', 'MERSİN', 'Silifke', 2),
(39, 'ER-1746', 'ER-MUĞLA-Fethiye-ABC', 'MUĞLA', 'Fethiye', 2),
(40, 'ER-1988', 'ER-YOZGAT-Merkez-ÖĞRETMEN', 'YOZGAT', 'Merkez', 2),
(41, 'ER-1988-1', 'ER-YOZGAT-Merkez-CAN', 'YOZGAT', 'Merkez', 2),
(42, 'KB-1988-2', 'KB-YOZGAT-Merkez-GAZİHAN', 'YOZGAT', 'Merkez', 2),
(43, 'ER-1991', 'ER-YOZGAT-Sorgun-TEST', 'YOZGAT', 'Sorgun', 2),
(44, 'ER-1991-1', 'ER-YOZGAT-Sorgun-GAZİHAN', 'YOZGAT', 'Sorgun', 2),
(45, 'K-1389', 'KIYAK-GAZİANTEP-Araban-NOKTA', 'GAZİANTEP', 'Araban', 4),
(46, 'K-1391', 'KIYAK-GAZİANTEP-İslahiye-HUZUR', 'GAZİANTEP', 'İslahiye', 4),
(47, 'K-1393', 'KIYAK-GAZİANTEP-Nizip-YILDIZ', 'GAZİANTEP', 'Nizip', 4),
(48, 'K-1396', 'KIYAK-GAZİANTEP-Şahinbey-XXX', 'GAZİANTEP', 'Şahinbey', 4),
(49, 'K-1397', 'KIYAK-GAZİANTEP-Şehitkamil-KIYAK', 'GAZİANTEP', 'Şehitkamil', 4),
(50, '120-0101-004', 'KEY-ADANA-CEYHAN-GÖNÜL KİTAP KIR', 'ADANA', 'CEYHAN', 5),
(51, '120-0101-002', 'KEY-ADANA-İMAMOĞLU-AY KIRTASİYE ', 'ADANA', 'İMAMOĞLU', 5),
(52, '120-0101-001', 'KEY-ADANA-KOZAN-GÖKTÜRK KIRTASİY', 'ADANA', 'KOZAN', 5),
(53, '120-0101-003', 'KEY-ADANA-MERKEZ-EKİN KİTAP KIRT', 'ADANA', 'MERKEZ', 5),
(54, '120-0101-005', 'KEY-ADANA-TUFANBEYLİ-KARADUMAN K', 'ADANA', 'TUFANBEYLİ', 5),
(55, '120-0102-005', 'KEY-ADIYAMAN-BESNİ-UĞUR BÖCEĞİ K', 'ADIYAMAN', 'BESNİ', 5),
(56, '120-0102-006', 'KEY-ADIYAMAN-GÖLBAŞI-HİLAL KIRTA', 'ADIYAMAN', 'GÖLBAŞI', 5),
(57, '120-0102-001', 'KEY-ADIYAMAN-KAHTA-ZAFER KIRTASİ', 'ADIYAMAN', 'KAHTA', 5),
(58, '120-0102-007', 'KEY-ADIYAMAN-MERKEZ-UMUT KİTAP K', 'ADIYAMAN', 'MERKEZ', 5),
(59, '120-0103-004', 'KEY-AFYONKARAHİSAR-BOLVADİN-MURA', 'AFYONKARAHİSAR', 'BOLVADİN', 5),
(60, '120-0103-003', 'KEY-AFYONKARAHİSAR-EMİRDAĞ-SAYGI', 'AFYONKARAHİSAR', 'EMİRDAĞ', 5),
(61, '120-0103-001', 'KEY-AFYONKARAHİSAR-MERKEZ-EGETAŞ', 'AFYONKARAHİSAR', 'MERKEZ', 5),
(62, '120-0103-006', 'KEY-AFYONKARAHİSAR-ŞUHUT-BİLİM K', 'AFYONKARAHİSAR', 'ŞUHUT', 5),
(63, '120-0104-005', 'KEY-AĞRI-DİYADİN-DUYGU KİTAP KIR', 'AĞRI', 'DİYADİN', 5),
(64, '120-0104-003', 'KEY-AĞRI-DOĞUBEYAZIT-ÖZTÜRK DAĞI', 'AĞRI', 'DOĞUBEYAZIT', 5),
(65, '120-0104-001', 'KEY-AĞRI-MERKEZ-3K CEYLAN KİTAP ', 'AĞRI', 'MERKEZ', 5),
(66, '120-0104-002', 'KEY-AĞRI-PATNOS-BİLGE KİTAP KIRT', 'AĞRI', 'PATNOS', 5),
(67, '120-0168-002', 'KEY-AKSARAY-MERKEZ-AKSARAY ANADO', 'AKSARAY', 'MERKEZ', 5),
(68, '120-0105-004', 'KEY-AMASYA-MERKEZ-SERHAT KİTAP K', 'AMASYA', 'MERKEZ', 5),
(69, '120-0105-003', 'KEY-AMASYA-MERZİFON-ÖNAL KİTAP K', 'AMASYA', 'MERZİFON', 5),
(70, '120-0106-001', 'KEY-ANKARA-MERKEZ-GÖZDE BASIM YA', 'ANKARA', 'MERKEZ', 5),
(71, '120-0106-003', 'KEY-ANKARA-ŞEREFLİKOÇHİSAR-ŞEREF', 'ANKARA', 'ŞEREFLİKOÇHİSAR', 5),
(72, '120-0107-002', 'KEY-ANTALYA-AKSU-TAMER KIRTASİYE', 'ANTALYA', 'AKSU', 5),
(73, '120-0107-005', 'KEY-ANTALYA-ALANYA-ÇINAR KİTAP K', 'ANTALYA', 'ALANYA', 5),
(74, '120-0107-001', 'KEY-ANTALYA-DÖŞEMEALTI-AYKUŞ KIR', 'ANTALYA', 'DÖŞEMEALTI', 5),
(75, '120-0107-013', 'KEY-ANTALYA-ELMALI-KARAGÜL KİTAP', 'ANTALYA', 'ELMALI', 5),
(76, '120-0107-004', 'KEY-ANTALYA-FİNİKE-SOYDAŞ KIRTAS', 'ANTALYA', 'FİNİKE', 5),
(77, '120-0107-007', 'KEY-ANTALYA-GAZİPAŞA-ÖZKURT KIRT', 'ANTALYA', 'GAZİPAŞA', 5),
(78, '120-0107-015', 'KEY-ANTALYA-KEMER-ERCAN KİTAP KI', 'ANTALYA', 'KEMER', 5),
(79, '120-0107-011', 'KEY-ANTALYA-KORKUTELİ-GÖKKUŞAĞI ', 'ANTALYA', 'KORKUTELİ', 5),
(80, '120-0107-003', 'KEY-ANTALYA-KUMLUCA-FAZİLET KIRT', 'ANTALYA', 'KUMLUCA', 5),
(81, '120-0107-009', 'KEY-ANTALYA-MANAVGAT-ÖNAL KIRTAS', 'ANTALYA', 'MANAVGAT', 5),
(82, '120-0107-017', 'KEY-ANTALYA-MURATPAŞA-KONYAALTI-', 'ANTALYA', 'MURATPAŞA-KONYAALTI-KEPEZ', 5),
(83, '120-0107-014', 'KEY-ANTALYA-SERİK-KANSU KİTABEVİ', 'ANTALYA', 'SERİK', 5),
(84, '120-0175-001', 'KEY-ARDAHAN-GÖLE-NTK KİTAP EVİ -', 'ARDAHAN', 'GÖLE', 5),
(85, '120-0109-005', 'KEY-AYDIN-KUŞADASI-İNSAN OKUR Kİ', 'AYDIN', 'KUŞADASI', 5),
(86, '120-0109-001', 'KEY-AYDIN-MERKEZ-EFE KİTAPÇILIK ', 'AYDIN', 'MERKEZ', 5),
(87, '120-0109-004', 'KEY-AYDIN-NAZİLLİ-KİTAPÇI KİTAP ', 'AYDIN', 'NAZİLLİ', 5),
(88, '120-0110-005', 'KEY-BALIKESİR-AYVALIK-EDREMİT-ÇE', 'BALIKESİR', 'AYVALIK-EDREMİT', 5),
(89, '120-0110-003', 'KEY-BALIKESİR-BANDIRMA-ÇAĞLAYAN ', 'BALIKESİR', 'BANDIRMA', 5),
(90, '120-0110-002', 'KEY-BALIKESİR-GÖNEN-VOLKAN KİTAP', 'BALIKESİR', 'GÖNEN', 5),
(91, '120-0110-001', 'KEY-BALIKESİR-MERKEZ-ÇETİN YAYIN', 'BALIKESİR', 'MERKEZ', 5),
(92, '120-0174-002', 'KEY-BARTIN-MERKEZ-EFE KİTAP KIRT', 'BARTIN', 'MERKEZ', 5),
(93, '120-0172-005', 'KEY-BATMAN-MERKEZ-MASAL KİTAP KI', 'BATMAN', 'MERKEZ', 5),
(94, '120-0169-002', 'KEY-BAYBURT-MERKEZ-PURUT KİTABEV', 'BAYBURT', 'MERKEZ', 5),
(95, '120-0111-002', 'KEY-BİLECİK-BOZÜYÜK-YAĞMUR KIRTA', 'BİLECİK', 'BOZÜYÜK', 5),
(96, '120-0111-003', 'KEY-BİLECİK-MERKEZ-VİZYON KİTABE', 'BİLECİK', 'MERKEZ', 5),
(97, '120-0112-002', 'KEY-BİNGÖL-MERKEZ-YENPA KİTAP KI', 'BİNGÖL', 'MERKEZ', 5),
(98, '120-0112-013', 'KEY-BİNGÖL-SOLHAN-SOLHAN ÖZLEM İ', 'BİNGÖL', 'SOLHAN', 5),
(99, '120-0113-007', 'KEY-BİTLİS-ADİLCEVAZ-NEHİR KİTAP', 'BİTLİS', 'ADİLCEVAZ', 5),
(100, '120-0113-008', 'KEY-BİTLİS-AHLAT-KARAKAPLAN TİCA', 'BİTLİS', 'AHLAT', 5),
(101, '120-0113-006', 'KEY-BİTLİS-GÜROYMAK-AKIN KİTAP K', 'BİTLİS', 'GÜROYMAK', 5),
(102, '120-0113-009', 'KEY-BİTLİS-MERKEZ-BİLGİ KIRTASİY', 'BİTLİS', 'MERKEZ', 5),
(103, '120-0113-005', 'KEY-BİTLİS-TATVAN-ENES KİTAP KIR', 'BİTLİS', 'TATVAN', 5),
(104, '120-0114-002', 'KEY-BOLU-GEREDE-YILDIZ KIRTASİYE', 'BOLU', 'GEREDE', 5),
(105, '120-0114-001', 'KEY-BOLU-MERKEZ-PETEK KİTAP KIRT', 'BOLU', 'MERKEZ', 5),
(106, '120-0115-002', 'KEY-BURDUR-BUCAK-AKIN KIRTASİYE ', 'BURDUR', 'BUCAK', 5),
(107, '120-0115-003', 'KEY-BURDUR-MERKEZ-ÜMRAN KİTAP KI', 'BURDUR', 'MERKEZ', 5),
(108, '120-0116-004', 'KEY-BURSA-İNEGÖL-DOSTLAR KİTAPEV', 'BURSA', 'İNEGÖL', 5),
(109, '120-0116-001', 'KEY-BURSA-MERKEZ-CEMAL BURAK ÖZE', 'BURSA', 'MERKEZ', 5),
(110, '120-0116-012', 'KEY-BURSA-ORHANGAZİ-ULUDAĞ KIRTA', 'BURSA', 'ORHANGAZİ', 5),
(111, '120-0117-004', 'KEY-ÇANAKKALE-BİGA-YERLEŞKE KİTA', 'ÇANAKKALE', 'BİGA', 5),
(112, '120-0117-001', 'KEY-ÇANAKKALE-ÇAN-BİLGE KİTAP KI', 'ÇANAKKALE', 'ÇAN', 5),
(113, '120-0117-005', 'KEY-ÇANAKKALE-MERKEZ-ATEŞBÖCEĞİ ', 'ÇANAKKALE', 'MERKEZ', 5),
(114, '120-0118-001', 'KEY-ÇANKIRI-MERKEZ-KEVSER KİTAP ', 'ÇANKIRI', 'MERKEZ', 5),
(115, '120-0119-005', 'KEY-ÇORUM-MERKEZ-ÇORUM KÜLTÜR ME', 'ÇORUM', 'MERKEZ', 5),
(116, '120-0119-004', 'KEY-ÇORUM-OSMANCIK-KARDEŞ KİTAP ', 'ÇORUM', 'OSMANCIK', 5),
(117, '120-0120-001', 'KEY-DENİZLİ-MERKEZ-BAŞARIRLAR YA', 'DENİZLİ', 'MERKEZ', 5),
(118, '120-0121-006', 'KEY-DİYARBAKIR-BİSMİL-TEBLİĞ KIR', 'DİYARBAKIR', 'BİSMİL', 5),
(119, '120-0121-007', 'KEY-DİYARBAKIR-ÇERMİK-YILDIRIM K', 'DİYARBAKIR', 'ÇERMİK', 5),
(120, '120-0121-005', 'KEY-DİYARBAKIR-ERGANİ-GÜVEN KİTA', 'DİYARBAKIR', 'ERGANİ', 5),
(121, '120-0121-004', 'KEY-DİYARBAKIR-MERKEZ-BAŞARI KAY', 'DİYARBAKIR', 'MERKEZ', 5),
(122, '120-0121-003', 'KEY-DİYARBAKIR-SİLVAN-HİLAL KIRT', 'DİYARBAKIR', 'SİLVAN', 5),
(123, '120-0181-001', 'KEY-DÜZCE-MERKEZ-AKDOĞAN KIRTASİ', 'DÜZCE', 'MERKEZ', 5),
(124, '120-0122-006', 'KEY-EDİRNE-KEŞAN-EVREN KIRTASİYE', 'EDİRNE', 'KEŞAN', 5),
(125, '120-0123-003', 'KEY-ELAZIĞ-MERKEZ-OLUŞUM KİTAP K', 'ELAZIĞ', 'MERKEZ', 5),
(126, '120-0124-001', 'KEY-ERZİNCAN-MERKEZ-GENÇ ÇARŞI K', 'ERZİNCAN', 'MERKEZ', 5),
(127, '120-0125-001', 'KEY-ERZURUM-MERKEZ-ERZURUM KÜLTÜ', 'ERZURUM', 'MERKEZ', 5),
(128, '120-0126-001', 'KEY-ESKİŞEHİR-MERKEZ-KAYNAK KİTA', 'ESKİŞEHİR', 'MERKEZ', 5),
(129, '120-0127-009', 'KEY-GAZİANTEP-MERKEZ-KAİZEN YAYI', 'GAZİANTEP', 'MERKEZ', 5),
(130, '120-0127-006', 'KEY-GAZİANTEP-NİZİP-MELEK GÖKKUŞ', 'GAZİANTEP', 'NİZİP', 5),
(131, '120-0127-004', 'KEY-GAZİANTEP-NURDAĞI-BİLGİSTAN ', 'GAZİANTEP', 'NURDAĞI', 5),
(132, '120-0128-004', 'KEY-GİRESUN-ESPİYE-TİREBOLU-GÜCE', 'GİRESUN', 'ESPİYE-TİREBOLU-GÜCE-YAĞLIDERE-DOĞANKENT', 5),
(133, '120-0128-003', 'KEY-GİRESUN-GÖRELE-ALTAN KİTABEV', 'GİRESUN', 'GÖRELE', 5),
(134, '120-0128-001', 'KEY-GİRESUN-MERKEZ-BULANCAK-NEJA', 'GİRESUN', 'MERKEZ-BULANCAK', 5),
(135, '120-0129-002', 'KEY-GÜMÜŞHANE-MERKEZ-REHBER KİTA', 'GÜMÜŞHANE', 'MERKEZ', 5),
(136, '120-0129-003', 'KEY-GÜMÜŞHANE-ŞİRAN-KELKİT-ÖTÜKE', 'GÜMÜŞHANE', 'ŞİRAN-KELKİT', 5),
(137, '120-0130-004', 'KEY-HAKKARİ-MERKEZ-AKSU KIRTASİY', 'HAKKARİ', 'MERKEZ', 5),
(138, '120-0130-005', 'KEY-HAKKARİ-YÜKSEKOVA-AKIN KIRTA', 'HAKKARİ', 'YÜKSEKOVA', 5),
(139, '120-0131-001', 'KEY-HATAY-ANTAKYA-SEYHAN YAYIN D', 'HATAY', 'ANTAKYA', 5),
(140, '120-0131-008', 'KEY-HATAY-DÖRTYOL-SARAY KİTAP KI', 'HATAY', 'DÖRTYOL', 5),
(141, '120-0131-003', 'KEY-HATAY-ERZİN-FIRAT KİTAP KIRT', 'HATAY', 'ERZİN', 5),
(142, '120-0131-009', 'KEY-HATAY-HASSA-DOLUNAY KIRTASİY', 'HATAY', 'HASSA', 5),
(143, '120-0131-010', 'KEY-HATAY-İSKENDERUN-BİLGE KİTAP', 'HATAY', 'İSKENDERUN', 5),
(144, '120-0131-002', 'KEY-HATAY-KIRIKHAN-NAR ÇİÇEĞİ Kİ', 'HATAY', 'KIRIKHAN', 5),
(145, '120-0131-012', 'KEY-HATAY-PAYAS-YİĞİT KIRTASİYE ', 'HATAY', 'PAYAS', 5),
(146, '120-0131-007', 'KEY-HATAY-SAMANDAĞ-SEYYAH KİTABE', 'HATAY', 'SAMANDAĞ', 5),
(147, '120-0176-004', 'KEY-IĞDIR-MERKEZ-IĞDIR ARI KIRTA', 'IĞDIR', 'MERKEZ', 5),
(148, '120-0176-003', 'KEY-IĞDIR-TUZLUCA-SALMAN KIRTASİ', 'IĞDIR', 'TUZLUCA', 5),
(149, '120-0132-003', 'KEY-ISPARTA-MERKEZ-SAYILI KİTAP ', 'ISPARTA', 'MERKEZ', 5),
(150, '120-0132-002', 'KEY-ISPARTA-YALVAÇ-HAKAN KİTABEV', 'ISPARTA', 'YALVAÇ', 5),
(151, '120-0134-064', 'KEY-İSTANBUL-ARNAVUTKÖY-ASAF KIR', 'İSTANBUL', 'ARNAVUTKÖY', 5),
(152, '120-0134-013', 'KEY-İSTANBUL-ATAŞEHİR-EBRULİ YAY', 'İSTANBUL', 'ATAŞEHİR', 5),
(153, '120-0134-004', 'KEY-İSTANBUL-AVCILAR-BUSE KİTAP ', 'İSTANBUL', 'AVCILAR', 5),
(154, '120-0134-021', 'KEY-İSTANBUL-BAĞCILAR-NEHİR KIRT', 'İSTANBUL', 'BAĞCILAR', 5),
(155, '120-0134-029', 'KEY-İSTANBUL-BAĞCILAR-FETİH KİTA', 'İSTANBUL', 'BAĞCILAR', 5),
(156, '', 'KEY-İSTANBUL-BAHÇELİEVLER-KALİTE', 'İSTANBUL', 'BAHÇELİEVLER', 5),
(157, '120-0134-002', 'KEY-İSTANBUL-BAŞAKŞEHİR-BİL-GE K', 'İSTANBUL', 'BAŞAKŞEHİR', 5),
(158, '120-0134-065', 'KEY-İSTANBUL-BAŞAKŞEHİR (KAYAŞEH', 'İSTANBUL', 'BAŞAKŞEHİR (KAYAŞEHİR)', 5),
(159, '120-0134-049', 'KEY-İSTANBUL-BEŞİKTAŞ-KAĞITHANE ', 'İSTANBUL', 'BEŞİKTAŞ-KAĞITHANE -SARIYER-ŞİŞLİ', 5),
(160, '120-0134-014', 'KEY-İSTANBUL-BEYKOZ-ORTANCA YAYI', 'İSTANBUL', 'BEYKOZ', 5),
(161, '120-0134-003', 'KEY-İSTANBUL-BEYLİKDÜZÜ-BÜYÜKÇEK', 'İSTANBUL', 'BEYLİKDÜZÜ-BÜYÜKÇEKMECE-SİLİVRİ', 5),
(162, '120-0134-056', 'KEY-İSTANBUL-BÜYÜKÇEKMECE-OKULYO', 'İSTANBUL', 'BÜYÜKÇEKMECE', 5),
(163, '120-0234-042', 'KEY-İSTANBUL-ÇATALCA-TEKİN KİTAP', 'İSTANBUL', 'ÇATALCA', 5),
(164, '120-0134-050', 'KEY-İSTANBUL-ÇEKMEKÖY-ULAŞ ATALA', 'İSTANBUL', 'ÇEKMEKÖY', 5),
(165, '120-0134-026', 'KEY-İSTANBUL-ESENLER-BİLGE KİTAP', 'İSTANBUL', 'ESENLER', 5),
(166, '120-0134-038', 'KEY-İSTANBUL-ESENYURT-AYIŞIĞI BA', 'İSTANBUL', 'ESENYURT', 5),
(167, '120-0234-029', 'KEY-İSTANBUL-EYÜP-ECE KİTAP KIRT', 'İSTANBUL', 'EYÜP', 5),
(168, '120-0134-035', 'KEY-İSTANBUL-GAZİOSMANPAŞA-DOST ', 'İSTANBUL', 'GAZİOSMANPAŞA', 5),
(169, '120-0234-041', 'KEY-İSTANBUL-FATİH-DORUK KİTAP K', 'İSTANBUL', 'FATİH', 5),
(170, '120-0134-047', 'KEY-İSTANBUL-GÜNGÖREN-GÜNGÖREN K', 'İSTANBUL', 'GÜNGÖREN', 5),
(171, '120-0134-040', 'KEY-İSTANBUL-KARTAL-PENDİK-BİLEN', 'İSTANBUL', 'KARTAL-PENDİK', 5),
(172, '120-0134-043', 'KEY-İSTANBUL-KÜÇÜKÇEKMECE-DEĞER ', 'İSTANBUL', 'KÜÇÜKÇEKMECE', 5),
(173, '120-0134-052', 'KEY-İSTANBUL-MALTEPE-KİTAPLAR ÜL', 'İSTANBUL', 'MALTEPE', 5),
(174, '120-0134-058', 'KEY-İSTANBUL-SANCAKTEPE-MURAT YA', 'İSTANBUL', 'SANCAKTEPE', 5),
(175, '120-0134-018', 'KEY-İSTANBUL-SULTANBEYLİ-RENÇBER', 'İSTANBUL', 'SULTANBEYLİ', 5),
(176, '120-0134-053', 'KEY-İSTANBUL-SULTANBEYLİ-ALİ YÖR', 'İSTANBUL', 'SULTANBEYLİ', 5),
(177, '120-0134-007', 'KEY-İSTANBUL-SULTANGAZİ-ÜSTÜN Kİ', 'İSTANBUL', 'SULTANGAZİ', 5),
(178, '120-0134-012', 'KEY-İSTANBUL-SULTANGAZİ-BAYRAMPA', 'İSTANBUL', 'SULTANGAZİ-BAYRAMPAŞA', 5),
(179, '120-0134-033', 'KEY-İSTANBUL-SULTANGAZİ (GAZİ MA', 'İSTANBUL', 'SULTANGAZİ (GAZİ MAH.)', 5),
(180, '120-0134-005', 'KEY-İSTANBUL-ÜMRANİYE-BOĞAZİÇİ K', 'İSTANBUL', 'ÜMRANİYE', 5),
(181, '120-0134-051', 'KEY-İSTANBUL-ÜSKÜDAR-ERCİYAS KIR', 'İSTANBUL', 'ÜSKÜDAR', 5),
(182, '120-0134-027', 'KEY-İSTANBUL-ZEYTİNBURNU-KAFDAĞI', 'İSTANBUL', 'ZEYTİNBURNU', 5),
(183, '120-0135-010', 'KEY-İZMİR-ALİAĞA-GEDİZ KIRTASİYE', 'İZMİR', 'ALİAĞA', 5),
(184, '120-0135-011', 'KEY-İZMİR-BERGAMA-AVDAN KIRTASİY', 'İZMİR', 'BERGAMA', 5),
(185, '120-0135-007', 'KEY-İZMİR-BORNOVA-BAYRAKLI-ÖZCAN', 'İZMİR', 'BORNOVA-BAYRAKLI', 5),
(186, '120-0135-001', 'KEY-İZMİR-BUCA-KONAK-GAZİEMİR-EN', 'İZMİR', 'BUCA-KONAK-GAZİEMİR', 5),
(187, '120-0135-009', 'KEY-İZMİR-ÇİĞLİ-KARŞIYAKA-SENA V', 'İZMİR', 'ÇİĞLİ-KARŞIYAKA', 5),
(188, '120-0135-005', 'KEY-İZMİR-KEMALPAŞA-DİLER KİTAP ', 'İZMİR', 'KEMALPAŞA', 5),
(189, '120-0135-006', 'KEY-İZMİR-MENDERES-KARAKALEM KİT', 'İZMİR', 'MENDERES', 5),
(190, '120-0135-008', 'KEY-İZMİR-MENEMEN-PARK KIRTASİYE', 'İZMİR', 'MENEMEN', 5),
(191, '120-0135-003', 'KEY-İZMİR-ÖDEMİŞ-KİRAZ-ELPA KİTA', 'İZMİR', 'ÖDEMİŞ-KİRAZ', 5),
(192, '120-0135-016', 'KEY-İZMİR-TİRE-BAYINDIR-ÖZGÜR Kİ', 'İZMİR', 'TİRE-BAYINDIR', 5),
(193, '120-0135-004', 'KEY-İZMİR-TORBALI-SEFA KİTAP KIR', 'İZMİR', 'TORBALI', 5),
(194, '120-0146-002', 'KEY-KAHRAMANMARAŞ-AFŞİN-ATILIM K', 'KAHRAMANMARAŞ', 'AFŞİN', 5),
(195, '120-0146-006', 'KEY-KAHRAMANMARAŞ-ELBİSTAN-KARDE', 'KAHRAMANMARAŞ', 'ELBİSTAN', 5),
(196, '120-0146-008', 'KEY-KAHRAMANMARAŞ-GÖKSUN-GÖKSUN ', 'KAHRAMANMARAŞ', 'GÖKSUN', 5),
(197, '120-0146-007', 'KEY-KAHRAMANMARAŞ-MERKEZ-TANIR K', 'KAHRAMANMARAŞ', 'MERKEZ', 5),
(198, '120-0146-001', 'KEY-KAHRAMANMARAŞ-PAZARCIK-KISAC', 'KAHRAMANMARAŞ', 'PAZARCIK', 5),
(199, '120-0178-002', 'KEY-KARABÜK-MERKEZ-ABDULLAHOĞLU ', 'KARABÜK', 'MERKEZ', 5),
(200, '120-0170-001', 'KEY-KARAMAN-MERKEZ-İSTİKLAL KİTA', 'KARAMAN', 'MERKEZ', 5),
(201, '120-0136-003', 'KEY-KARS-MERKEZ-ÖZKIRTAY KİTAP K', 'KARS', 'MERKEZ', 5),
(202, '120-0137-005', 'KEY-KASTAMONU-MERKEZ-KOZA KİTABE', 'KASTAMONU', 'MERKEZ', 5),
(203, '120-0138-005', 'KEY-KAYSERİ-BÜNYAN-ÜNAL KIRTASİY', 'KAYSERİ', 'BÜNYAN', 5),
(204, '120-0138-003', 'KEY-KAYSERİ-DEVELİ-YAPRAK YAYIN ', 'KAYSERİ', 'DEVELİ', 5),
(205, '120-0138-002', 'KEY-KAYSERİ-MERKEZ-OĞUZHAN KİTAP', 'KAYSERİ', 'MERKEZ', 5),
(206, '120-0139-002', 'KEY-KIRIKKALE-LÜLEBURGAZ-KAROFFİ', 'KIRIKKALE', 'LÜLEBURGAZ', 5),
(207, '120-0334-003', 'KEY-KIRKLARELİ-MERKEZ-ŞEMSİ GÜZE', 'KIRKLARELİ', 'MERKEZ', 5),
(208, '120-0139-006', 'KEY-KIRKLARELİ-PINARHİSAR-VİZE-M', 'KIRKLARELİ', 'PINARHİSAR-VİZE', 5),
(209, '120-0140-001', 'KEY-KIRŞEHİR-MERKEZ-DUMAN KIRTAS', 'KIRŞEHİR', 'MERKEZ', 5),
(210, '120-0140-002', 'KEY-KIRŞEHİR-MUCUR-ALP KİTAP KIR', 'KIRŞEHİR', 'MUCUR', 5),
(211, '120-0179-001', 'KEY-KİLİS-MERKEZ-BEYOĞLU KIRTASİ', 'KİLİS', 'MERKEZ', 5),
(212, '120-0141-006', 'KEY-KOCAELİ-DERİNCE-YALÇINDAĞ Kİ', 'KOCAELİ', 'DERİNCE', 5),
(213, '120-0141-002', 'KEY-KOCAELİ-GEBZE-ERCAN KIRTASİY', 'KOCAELİ', 'GEBZE', 5),
(214, '120-0141-004', 'KEY-KOCAELİ-GÖLCÜK-ERDEN TÜRKER', 'KOCAELİ', 'GÖLCÜK', 5),
(215, '120-0141-005', 'KEY-KOCAELİ-KANDIRA-BİLGİ KIRTAS', 'KOCAELİ', 'KANDIRA', 5),
(216, '120-0142-002', 'KEY-KONYA-AKŞEHİR-ÖĞRENCİ KIRTAS', 'KONYA', 'AKŞEHİR', 5),
(217, '120-0142-003', 'KEY-KONYA-BEYŞEHİR-SÖZBİRLER KİT', 'KONYA', 'BEYŞEHİR', 5),
(218, '120-0142-010', 'KEY-KONYA-CİHANBEYLİ-YILMAZ KIRT', 'KONYA', 'CİHANBEYLİ', 5),
(219, '120-0142-008', 'KEY-KONYA-EREĞLİ-CEM KIRTASİYE -', 'KONYA', 'EREĞLİ', 5),
(220, '120-0142-011', 'KEY-KONYA-ILGIN-KADINHANI-BARIŞ ', 'KONYA', 'ILGIN-KADINHANI', 5),
(221, '120-0142-009', 'KEY-KONYA-KARAPINAR-CESUR KIRTAS', 'KONYA', 'KARAPINAR', 5),
(222, '120-0142-006', 'KEY-KONYA-MERKEZ-OKAN ADIYAMAN', 'KONYA', 'MERKEZ', 5),
(223, '120-0142-004', 'KEY-KONYA-SEYDİŞEHİR-SAĞLAM KIRT', 'KONYA', 'SEYDİŞEHİR', 5),
(224, '120-0143-002', 'KEY-KÜTAHYA-MERKEZ-TAVŞANLI-BİRK', 'KÜTAHYA', 'MERKEZ-TAVŞANLI', 5),
(225, '120-0143-003', 'KEY-KÜTAHYA-SİMAV-EĞİTİM KIRTASİ', 'KÜTAHYA', 'SİMAV', 5),
(226, '120-0144-001', 'KEY-MALATYA-MERKEZ-NOKTA YAYIN D', 'MALATYA', 'MERKEZ', 5),
(227, '120-0145-007', 'KEY-MANİSA-AKHİSAR-ZEYTİN KİTAP ', 'MANİSA', 'AKHİSAR', 5),
(228, '120-0145-001', 'KEY-MANİSA-ALAŞEHİR-UMUT KIRTASİ', 'MANİSA', 'ALAŞEHİR', 5),
(229, '120-0145-005', 'KEY-MANİSA-MERKEZ-MURAT KIRTASİY', 'MANİSA', 'MERKEZ', 5),
(230, '120-0145-008', 'KEY-MANİSA-SALİHLİ-TURGUTLU-SILA', 'MANİSA', 'SALİHLİ-TURGUTLU', 5),
(231, '120-0145-009', 'KEY-MANİSA-SOMA-KIRKAĞAÇ-TÜRKER ', 'MANİSA', 'SOMA-KIRKAĞAÇ', 5),
(232, '120-0147-001', 'KEY-MARDİN-MERKEZ-KEY KİTABEVİ -', 'MARDİN', 'MERKEZ', 5),
(233, '120-0147-002', 'KEY-MARDİN-MİDYAT-ŞIRNAK-SİLOPİ-', 'MARDİN', 'MİDYAT-ŞIRNAK-SİLOPİ', 5),
(234, '120-0133-007', 'KEY-MERSİN-ANAMUR-BOZYAZI-GÜNCE ', 'MERSİN', 'ANAMUR-BOZYAZI', 5),
(235, '120-0133-010', 'KEY-MERSİN-ERDEMLİ-ÇINAR KİTAP K', 'MERSİN', 'ERDEMLİ', 5),
(236, '120-0133-006', 'KEY-MERSİN-MERKEZ-BİLFA YAYIN DA', 'MERSİN', 'MERKEZ', 5),
(237, '120-0133-009', 'KEY-MERSİN-MUT-CEM KIRTASİYE - C', 'MERSİN', 'MUT', 5),
(238, '120-0133-002', 'KEY-MERSİN-SİLİFKE-TOROS KİTAP K', 'MERSİN', 'SİLİFKE', 5),
(239, '120-0133-004', 'KEY-MERSİN-TARSUS-KÜLTÜR DAĞITIM', 'MERSİN', 'TARSUS', 5),
(240, '120-0148-003', 'KEY-MUĞLA-BODRUM-YASER KİTABEVİ ', 'MUĞLA', 'BODRUM', 5),
(241, '120-0148-001', 'KEY-MUĞLA-FETHİYE-PINAR KİTAP KI', 'MUĞLA', 'FETHİYE', 5),
(242, '120-0148-002', 'KEY-MUĞLA-MERKEZ-YATAĞAN-MARMARİ', 'MUĞLA', 'MERKEZ-YATAĞAN-MARMARİS', 5),
(243, '120-0149-006', 'KEY-MUŞ-BULANIK-EĞİTİM KIRTASİYE', 'MUŞ', 'BULANIK', 5),
(244, '120-0149-003', 'KEY-MUŞ-MALAZGİRT-ÖZTÜRK KİTAP K', 'MUŞ', 'MALAZGİRT', 5),
(245, '120-0149-007', 'KEY-MUŞ-MERKEZ-HASKÖY-EMİR KİTAP', 'MUŞ', 'MERKEZ-HASKÖY', 5),
(246, '120-0149-004', 'KEY-MUŞ-VARTO-SEÇKİN KIRTASİYE -', 'MUŞ', 'VARTO', 5),
(247, '120-0150-001', 'KEY-NEVŞEHİR-MERKEZ-ARDA KİTAP K', 'NEVŞEHİR', 'MERKEZ', 5),
(248, '120-0151-002', 'KEY-NİĞDE-BOR-TUĞRA KIRTASİYE - ', 'NİĞDE', 'BOR', 5),
(249, '120-0151-004', 'KEY-NİĞDE-MERKEZ-ADEM KİTAP KIRT', 'NİĞDE', 'MERKEZ', 5),
(250, '120-0152-004', 'KEY-ORDU-FATSA-DUMLUPINAR KIRTAS', 'ORDU', 'FATSA', 5),
(251, '120-0152-005', 'KEY-ORDU-KABATAŞ-İLİM KİTAP KIRT', 'ORDU', 'KABATAŞ', 5),
(252, '120-0152-003', 'KEY-ORDU-MERKEZ-EFE KİTABEVİ - Ö', 'ORDU', 'MERKEZ', 5),
(253, '120-0152-002', 'KEY-ORDU-ÜNYE-YDS KİTAP KIRTASİY', 'ORDU', 'ÜNYE', 5),
(254, '120-0180-006', 'KEY-OSMANİYE-DÜZİÇİ-ONUR KIRTASİ', 'OSMANİYE', 'DÜZİÇİ', 5),
(255, '120-0180-005', 'KEY-OSMANİYE-KADİRLİ-BEYAZ KİTAP', 'OSMANİYE', 'KADİRLİ', 5),
(256, '120-0180-007', 'KEY-OSMANİYE-MERKEZ-PUSULA KİTAB', 'OSMANİYE', 'MERKEZ', 5),
(257, '120-0153-001', 'KEY-RİZE-MERKEZ-MAHİR KİTAP DAĞI', 'RİZE', 'MERKEZ', 5),
(258, '120-0154-009', 'KEY-SAKARYA-AKYAZI-FURKAN KİTABE', 'SAKARYA', 'AKYAZI', 5),
(259, '120-0154-005', 'KEY-SAKARYA-HENDEK-KALE KİTAP KI', 'SAKARYA', 'HENDEK', 5),
(260, '120-0154-003', 'KEY-SAKARYA-KAYNARCA-BİLGİ KIRTA', 'SAKARYA', 'KAYNARCA', 5),
(261, '120-0154-001', 'KEY-SAKARYA-MERKEZ-ADA BARIŞ KİT', 'SAKARYA', 'MERKEZ', 5),
(262, '120-0155-006', 'KEY-SAMSUN-BAFRA-SERPA KİTAP KIR', 'SAMSUN', 'BAFRA', 5),
(263, '120-0155-004', 'KEY-SAMSUN-ÇARŞAMBA-TERME-BATI B', 'SAMSUN', 'ÇARŞAMBA-TERME', 5),
(264, '120-0155-001', 'KEY-SAMSUN-HAVZA-SETENAY DAĞITIM', 'SAMSUN', 'HAVZA', 5),
(265, '120-0155-005', 'KEY-SAMSUN-MERKEZ-KARADENİZ KİTA', 'SAMSUN', 'MERKEZ', 5),
(266, '120-0156-003', 'KEY-SİİRT-MERKEZ-YAYIN BAHÇESİ -', 'SİİRT', 'MERKEZ', 5),
(267, '120-0157-005', 'KEY-SİNOP-AYANCIK-GÜVEN KİTAP SA', 'SİNOP', 'AYANCIK', 5),
(268, '120-0157-004', 'KEY-SİNOP-BOYABAT-YILDIZ KİTAP K', 'SİNOP', 'BOYABAT', 5),
(269, '120-0157-007', 'KEY-SİNOP-DURAĞAN-HİCRET KİTAP K', 'SİNOP', 'DURAĞAN', 5),
(270, '120-0157-002', 'KEY-SİNOP-GERZE-EYLÜL KIRTASİYE ', 'SİNOP', 'GERZE', 5),
(271, '120-0157-003', 'KEY-SİNOP-MERKEZ-SEÇİL KIRTASİYE', 'SİNOP', 'MERKEZ', 5),
(272, '120-0157-006', 'KEY-SİNOP-TÜRKELİ-ÖZCANLAR KIRTA', 'SİNOP', 'TÜRKELİ', 5),
(273, '120-0158-006', 'KEY-SİVAS-MERKEZ-VİLAYET KİTABEV', 'SİVAS', 'MERKEZ', 5),
(274, '120-0163-010', 'KEY-ŞANLIURFA-BİRECİK-SEDAT KIRT', 'ŞANLIURFA', 'BİRECİK', 5),
(275, '120-0163-007', 'KEY-ŞANLIURFA-CEYLANPINAR-NİL Kİ', 'ŞANLIURFA', 'CEYLANPINAR', 5),
(276, '120-0163-011', 'KEY-ŞANLIURFA-HİLVAN-EĞİTİM KIRT', 'ŞANLIURFA', 'HİLVAN', 5),
(277, '120-0163-009', 'KEY-ŞANLIURFA-MERKEZ-ZEKİ KİTAP ', 'ŞANLIURFA', 'MERKEZ', 5),
(278, '120-0163-005', 'KEY-ŞANLIURFA-SİVEREK-EMEK KIRTA', 'ŞANLIURFA', 'SİVEREK', 5),
(279, '120-0163-008', 'KEY-ŞANLIURFA-VİRANŞEHİR-FARUK K', 'ŞANLIURFA', 'VİRANŞEHİR', 5),
(280, '120-0159-010', 'KEY-TEKİRDAĞ-ÇORLU-41 KİTAP BİLİ', 'TEKİRDAĞ', 'ÇORLU', 5),
(281, '120-0159-005', 'KEY-TEKİRDAĞ-KAPAKLI - ÇERKEZKÖY', 'TEKİRDAĞ', 'KAPAKLI - ÇERKEZKÖY', 5),
(282, '120-0159-008', 'KEY-TEKİRDAĞ-MERKEZ-ZEKİ KIRTASİ', 'TEKİRDAĞ', 'MERKEZ', 5),
(283, '120-0159-001', 'KEY-TEKİRDAĞ-SARAY-ABC KIRTASİYE', 'TEKİRDAĞ', 'SARAY', 5),
(284, '120-0160-008', 'KEY-TOKAT-ERBAA-UFUK GIDA KIRTAS', 'TOKAT', 'ERBAA', 5),
(285, '120-0160-005', 'KEY-TOKAT-MERKEZ-PRİZMA KİTAP KI', 'TOKAT', 'MERKEZ', 5),
(286, '120-0160-004', 'KEY-TOKAT-ZİLE-ADA KIRTASİYE - E', 'TOKAT', 'ZİLE', 5),
(287, '120-0161-001', 'KEY-TRABZON-MERKEZ-ANT KİTAP KIR', 'TRABZON', 'MERKEZ', 5),
(288, '120-0162-002', 'KEY-TUNCELİ-MERKEZ-SEÇKİN KIRTAS', 'TUNCELİ', 'MERKEZ', 5),
(289, '120-0164-001', 'KEY-UŞAK-MERKEZ-MSM KİTAP KIRTAS', 'UŞAK', 'MERKEZ', 5),
(290, '120-0165-006', 'KEY-VAN-ÇALDIRAN-NİRVANA KIRTASİ', 'VAN', 'ÇALDIRAN', 5),
(291, '120-0165-002', 'KEY-VAN-ERCİŞ-BAŞAK KİTAP KIRTAS', 'VAN', 'ERCİŞ', 5),
(292, '120-0165-004', 'KEY-VAN-MERKEZ-YAVUZ KIRTASİYE -', 'VAN', 'MERKEZ', 5),
(293, '120-0165-007', 'KEY-VAN-MURADİYE-ALİM KIRTASİYE ', 'VAN', 'MURADİYE', 5),
(294, '120-0177-002', 'KEY-YALOVA-MERKEZ-BİLGİ KİTAP KI', 'YALOVA', 'MERKEZ', 5),
(295, '120-0166-003', 'KEY-YOZGAT-YERKÖY-DK DÖRTKALEM K', 'YOZGAT', 'YERKÖY', 5),
(296, '120-0167-002', 'KEY-ZONGULDAK-DEVREK-UĞUR KİTAP ', 'ZONGULDAK', 'DEVREK', 5),
(297, '120-0167-003', 'KEY-ZONGULDAK-KARADENİZ EREĞLİ-Ö', 'ZONGULDAK', 'KARADENİZ EREĞLİ', 5),
(298, '120.06.01.002', 'ÜÇGEN-Adana-Ceyhan-Bozkurt Kitap', 'Adana', 'Ceyhan', 5),
(299, '120.06.01.012', 'ÜÇGEN-Adana-Kozan-Erdem Kitap Kı', 'Adana', 'Kozan', 5),
(300, '120.06.01.026', 'ÜÇGEN-Adana-Kozan-Kardeşler Kit.', 'Adana', 'Kozan', 5),
(301, '120.06.01.009', 'ÜÇGEN-Adana-Yüreğir-Karacan Kita', 'Adana', 'Yüreğir', 5),
(302, '120.12.02.001', 'ÜÇGEN-Adıyaman-Gölbaşı-Barış Kır', 'Adıyaman', 'Gölbaşı', 5),
(303, '120.12.02.009', 'ÜÇGEN-Adıyaman-Merkez-Dinamik Kı', 'Adıyaman', 'Merkez', 5),
(304, '120.05.03.022', 'ÜÇGEN-Afyonkarahisar-Çay-Yağmur ', 'Afyonkarahisar', 'Çay', 5),
(305, '120.05.03.002', 'ÜÇGEN-Afyonkarahisar-Dinar-Yaşar', 'Afyonkarahisar', 'Dinar', 5),
(306, '120.05.03.005', 'ÜÇGEN-Afyonkarahisar-Merkez-Erde', 'Afyonkarahisar', 'Merkez', 5),
(307, '120.05.03.013', 'ÜÇGEN-Afyonkarahisar-Şuhut-Bilim', 'Afyonkarahisar', 'Şuhut', 5),
(308, '120.09.04.008', 'ÜÇGEN-Ağrı-Diyadin-Gökmen Kırt. ', 'Ağrı', 'Diyadin', 5),
(309, '120.09.04.002', 'ÜÇGEN-Ağrı-Merkez-Barış Kitap Kı', 'Ağrı', 'Merkez', 5),
(310, '120.08.68.002', 'ÜÇGEN-Aksaray-Merkez-Beren Kitap', 'Aksaray', 'Merkez', 5),
(311, '120.08.68.007', 'ÜÇGEN-Aksaray-Ortaköy-Pınar Akdo', 'Aksaray', 'Ortaköy', 5),
(312, '120.10.05.015', 'ÜÇGEN-Amasya-Merkez-Zafer Kırt. ', 'Amasya', 'Merkez', 5),
(313, '120.10.05.018', 'ÜÇGEN-Amasya-Merzifon-Önal Kit.K', 'Amasya', 'Merzifon', 5),
(314, '120.07.06.017', 'ÜÇGEN-Ankara-Keçiören-Ankara Kır', 'Ankara', 'Keçiören', 5),
(315, '120.06.07.073', 'ÜÇGEN-Antalya-Alanya-Anka Kit. K', 'Antalya', 'Alanya', 5),
(316, '120.06.07.005', 'ÜÇGEN-Antalya-Demre-Öğretmen Kır', 'Antalya', 'Demre', 5),
(317, '120.06.07.006', 'ÜÇGEN-Antalya-Döşemealtı-Aykuş K', 'Antalya', 'Döşemealtı', 5),
(318, '120.06.07.083', 'ÜÇGEN-Antalya-Elmalı-Türkmen Kır', 'Antalya', 'Elmalı', 5),
(319, '120.06.07.009', 'ÜÇGEN-Antalya-Finike-Soydaş Kırt', 'Antalya', 'Finike', 5),
(320, '120.06.07.012', 'ÜÇGEN-Antalya-Gazipaşa-Özkurt Kı', 'Antalya', 'Gazipaşa', 5),
(321, '120.06.07.021', 'ÜÇGEN-Antalya-Kumluca-Fazilet Kı', 'Antalya', 'Kumluca', 5),
(322, '120.06.07.024', 'ÜÇGEN-Antalya-Manavgat-Arslan Kı', 'Antalya', 'Manavgat', 5),
(323, '120.06.07.049', 'ÜÇGEN-Antalya-Muratpaşa-Alfa Etü', 'Antalya', 'Muratpaşa', 5),
(324, '120.06.07.045', 'ÜÇGEN-Antalya-Serik-Erdemir Kırt', 'Antalya', 'Serik', 5),
(325, '120.09.75.004', 'ÜÇGEN-Ardahan-Merkez-Deniz Rekla', 'Ardahan', 'Merkez', 5),
(326, '120.11.08.004', 'ÜÇGEN-Artvin-Hopa-Yenigül kırtas', 'Artvin', 'Hopa', 5),
(327, '120.06.07.071', 'ÜÇGEN-Aydın-Didim-Nazım Barış Şa', 'Aydın', 'Didim', 5),
(328, '120.05.09.005', 'ÜÇGEN-Aydın-Germencik-Okyanus Kı', 'Aydın', 'Germencik', 5),
(329, '120.05.09.215', 'ÜÇGEN-Aydın-Merkez-KAZIM OĞUZ', 'Aydın', 'Merkez', 5),
(330, '120.05.09.008', 'ÜÇGEN-Aydın-Nazilli-Bilgi Dağıtı', 'Aydın', 'Nazilli', 5),
(331, '120.05.09.013', 'ÜÇGEN-Aydın-Söke-Green Love Kita', 'Aydın', 'Söke', 5),
(332, '120.03.10.005', 'ÜÇGEN-Balıkesir-Bandırma-Seçgin ', 'Balıkesir', 'Bandırma', 5),
(333, '120.03.10.033', 'ÜÇGEN-Balıkesir-Bandırma-Özboy K', 'Balıkesir', 'Bandırma', 5),
(334, '120.03.10.009', 'ÜÇGEN-Balıkesir-Gönen-Volkan Kit', 'Balıkesir', 'Gönen', 5),
(335, '120.03.10.012', 'ÜÇGEN-Balıkesir-Karesi-CEYHUN ÇE', 'Balıkesir', 'Karesi', 5),
(336, '120.10.74.005', 'ÜÇGEN-Bartın-Merkez-Efe Toys Wor', 'Bartın', 'Merkez', 5),
(337, '120.12.72.012', 'ÜÇGEN-Batman-Merkez-Evrensel Kit', 'Batman', 'Merkez', 5),
(338, '120.04.11.011', 'ÜÇGEN-Bilecik-Bozüyük-Bozüyük Kı', 'Bilecik', 'Bozüyük', 5),
(339, '120.04.11.008', 'ÜÇGEN-Bilecik-Merkez-Vizyon Kita', 'Bilecik', 'Merkez', 5),
(340, '120.09.12.007', 'ÜÇGEN-Bingöl-Merkez-Turhan Kit. ', 'Bingöl', 'Merkez', 5),
(341, '120.09.13.007', 'ÜÇGEN-Bitlis-Adilcevaz-Nehir Kit', 'Bitlis', 'Adilcevaz', 5),
(342, '120.09.13.004', 'ÜÇGEN-Bitlis-Tatvan-İncesu Kırta', 'Bitlis', 'Tatvan', 5),
(343, '120.04.14.001', 'ÜÇGEN-Bolu-Gerede-AYDIN KIRTASIY', 'Bolu', 'Gerede', 5),
(344, '120.04.14.006', 'ÜÇGEN-Bolu-Merkez-Petek Kırt. Lt', 'Bolu', 'Merkez', 5),
(345, '120.06.15.007', 'ÜÇGEN-Burdur-Bucak-Bilgi Kitap K', 'Burdur', 'Bucak', 5),
(346, '120.06.15.013', 'ÜÇGEN-Burdur-Merkez-Bulut Kitabe', 'Burdur', 'Merkez', 5),
(347, '120.04.16.001', 'ÜÇGEN-Bursa-Gemlik-Ferhat Kırtas', 'Bursa', 'Gemlik', 5),
(348, '120.04.16.003', 'ÜÇGEN-Bursa-İnegöl-Dostlar Kitab', 'Bursa', 'İnegöl', 5),
(349, '120.04.16.032', 'ÜÇGEN-Bursa-Karacabey-KRC Ütopya', 'Bursa', 'Karacabey', 5),
(350, '120.04.16.008', 'ÜÇGEN-Bursa-Mustafakemalpaşa-Ant', 'Bursa', 'Mustafakemalpaşa', 5),
(351, '120.04.16.034', 'ÜÇGEN-Bursa-Nilüfer-ENTE KİTAPÇI', 'Bursa', 'Nilüfer', 5),
(352, '120.04.16.039', 'ÜÇGEN-Bursa-Orhangazi-İrem Kırta', 'Bursa', 'Orhangazi', 5),
(353, '120.04.16.023', 'ÜÇGEN-Bursa-Yenişehir-Akademi Kı', 'Bursa', 'Yenişehir', 5),
(354, '120.03.17.004', 'ÜÇGEN-Çanakkale-Biga-Yerleşke Ki', 'Çanakkale', 'Biga', 5),
(355, '120.03.17.005', 'ÜÇGEN-Çanakkale-Çan-Bilge Kitap ', 'Çanakkale', 'Çan', 5),
(356, '120.03.17.007', 'ÜÇGEN-Çanakkale-Gelibolu-Emin Kı', 'Çanakkale', 'Gelibolu', 5),
(357, '120.03.17.011', 'ÜÇGEN-Çanakkale-Merkez-Beste Kır', 'Çanakkale', 'Merkez', 5),
(358, '120.10.18.003', 'ÜÇGEN-Çankırı-Merkez-Kevser Kita', 'Çankırı', 'Merkez', 5),
(359, '120.10.19.002', 'ÜÇGEN-Çorum-Kargı-Bilgi Çağı Kit', 'Çorum', 'Kargı', 5),
(360, '120.10.19.015', 'ÜÇGEN-Çorum-Osmancık-Kardeş Kit.', 'Çorum', 'Osmancık', 5),
(361, '120.10.19.016', 'ÜÇGEN-Çorum-Sungurlu-Çizgi Kitap', 'Çorum', 'Sungurlu', 5),
(362, '120.05.20.001', 'ÜÇGEN-Denizli-Beyağaç-Başarırlar', 'Denizli', 'Beyağaç', 5),
(363, '120.12.21.025', 'ÜÇGEN-Diyarbakır-Ergani-Güven Ki', 'Diyarbakır', 'Ergani', 5),
(364, '120.12.21.005', 'ÜÇGEN-Diyarbakır-Kayapınar-Başar', 'Diyarbakır', 'Kayapınar', 5),
(365, '120.04.81.002', 'ÜÇGEN-Düzce-Kaynaşlı-Akdoğan Orm', 'Düzce', 'Kaynaşlı', 5),
(366, '120.09.23.009', 'ÜÇGEN-Elazığ-Karakoçan-Akdağ Kır', 'Elazığ', 'Karakoçan', 5),
(367, '120.09.23.007', 'ÜÇGEN-Elazığ-Merkez-Öyküm Kit. K', 'Elazığ', 'Merkez', 5),
(368, '120.09.24.001', 'ÜÇGEN-Erzincan-Merkez-Asya Kit. ', 'Erzincan', 'Merkez', 5),
(369, '120.09.25.004', 'ÜÇGEN-Erzurum-Yakutiye-Erzurum K', 'Erzurum', 'Yakutiye', 5),
(370, '120.04.26.008', 'ÜÇGEN-Eskişehir-Odunpazarı-Kahra', 'Eskişehir', 'Odunpazarı', 5),
(371, '120.04.26.013', 'ÜÇGEN-Eskişehir-Odunpazarı-Atak ', 'Eskişehir', 'Odunpazarı', 5),
(372, '120.12.27.010', 'ÜÇGEN-Gaziantep-Şehitkamil-Kıyak', 'Gaziantep', 'Şehitkamil', 5),
(373, '120.11.28.001', 'ÜÇGEN-Giresun-Merkez-Özgökkuşağı', 'Giresun', 'Merkez', 5),
(374, '120.11.29.008', 'ÜÇGEN-Gümüşhane-Kelkit-Kelkit Ki', 'Gümüşhane', 'Kelkit', 5),
(375, '120.11.29.007', 'ÜÇGEN-Gümüşhane-Merkez-Sote Kita', 'Gümüşhane', 'Merkez', 5),
(376, '120.09.30.006', 'ÜÇGEN-Hakkari-Yüksekova-Ova Kita', 'Hakkari', 'Yüksekova', 5),
(377, '120.06.31.028', 'ÜÇGEN-Hatay-Belen-Seyhan Yay. Da', 'Hatay', 'Belen', 5),
(378, '120.06.31.223', 'ÜÇGEN-Hatay-Dörtyol-Dörtyol Sam ', 'Hatay', 'Dörtyol', 5),
(379, '120.06.31.034', 'ÜÇGEN-Hatay-Erzin-Nehir Kitap Kı', 'Hatay', 'Erzin', 5),
(380, '120.06.31.015', 'ÜÇGEN-Hatay-İskenderun-ÜNİPA BAS', 'Hatay', 'İskenderun', 5),
(381, '120.06.31.222', 'ÜÇGEN-Hatay-Kırıkhan-Nar Çiçeği ', 'Hatay', 'Kırıkhan', 5),
(382, '120.06.31.008', 'ÜÇGEN-Hatay-Samandağ-Dünya Kitab', 'Hatay', 'Samandağ', 5),
(383, '120.06.31.224', 'ÜÇGEN-Hatay-Samandağ-Mavi Kit.Kı', 'Hatay', 'Samandağ', 5),
(384, '120.09.76.003', 'ÜÇGEN-Iğdır-Merkez-Simge Kitap K', 'Iğdır', 'Merkez', 5),
(385, '120.06.32.020', 'ÜÇGEN-Isparta-Eğirdir-Uysal Tica', 'Isparta', 'Eğirdir', 5),
(386, '120.06.32.006', 'ÜÇGEN-Isparta-Merkez-Hondu Kit.K', 'Isparta', 'Merkez', 5),
(387, '120.06.32.013', 'ÜÇGEN-Isparta-Şarkikaraağaç-Asya', 'Isparta', 'Şarkikaraağaç', 5),
(388, '120.06.32.018', 'ÜÇGEN-Isparta-Yalvaç-Hakan Kitab', 'Isparta', 'Yalvaç', 5),
(389, '120.01.34.081', 'ÜÇGEN-İstanbul-Arnavutköy-Mor La', 'İstanbul', 'Arnavutköy', 5),
(390, '120.01.34.140', 'ÜÇGEN-İstanbul-Avcılar-Denizatı ', 'İstanbul', 'Avcılar', 5),
(391, '120.01.34.585', 'ÜÇGEN-İstanbul-Bağcılar-MUSTAFA ', 'İstanbul', 'Bağcılar', 5),
(392, '120.01.34.003', 'ÜÇGEN-İstanbul-Bahçelievler-Akgü', 'İstanbul', 'Bahçelievler', 5),
(393, '120.01.34.237', 'ÜÇGEN-İstanbul-Bahçelievler-Güve', 'İstanbul', 'Bahçelievler', 5),
(394, '120.01.34.145', 'ÜÇGEN-İstanbul-Bayrampaşa-111111', 'İstanbul', 'Bayrampaşa', 5),
(395, '120.01.34.232', 'ÜÇGEN-İstanbul-Bayrampaşa-Abc Kı', 'İstanbul', 'Bayrampaşa', 5),
(396, '120.02.34.025', 'ÜÇGEN-İstanbul-Beykoz-Ortanca Ya', 'İstanbul', 'Beykoz', 5),
(397, '120.01.34.173', 'ÜÇGEN-İstanbul-Beylikdüzü-Murat ', 'İstanbul', 'Beylikdüzü', 5),
(398, '120.01.34.477', 'ÜÇGEN-İstanbul-Beyoğlu-Enver Çak', 'İstanbul', 'Beyoğlu', 5),
(399, '120.01.34.272', 'ÜÇGEN-İstanbul-Büyükçekmece-Oba ', 'İstanbul', 'Büyükçekmece', 5),
(400, '120.02.34.079', 'ÜÇGEN-İstanbul-Çekmeköy-Bilge Ki', 'İstanbul', 'Çekmeköy', 5),
(401, '120.01.34.059', 'ÜÇGEN-İstanbul-Esenler-Serdar Er', 'İstanbul', 'Esenler', 5),
(402, '120.01.34.004', 'ÜÇGEN-İstanbul-Esenyurt-Atlas Ok', 'İstanbul', 'Esenyurt', 5),
(403, '120.01.34.105', 'ÜÇGEN-İstanbul-Esenyurt-Haldun G', 'İstanbul', 'Esenyurt', 5),
(404, '120.01.34.089', 'ÜÇGEN-İstanbul-Gaziosmanpaşa-Ram', 'İstanbul', 'Gaziosmanpaşa', 5),
(405, '120.01.34.635', 'ÜÇGEN-İstanbul-Gaziosmanpaşa-Bil', 'İstanbul', 'Gaziosmanpaşa', 5),
(406, '120.01.34.562', 'ÜÇGEN-İstanbul-Güngören-Merter K', 'İstanbul', 'Güngören', 5),
(407, '120.02.34.053', 'ÜÇGEN-İstanbul-Kadıköy-DEVRİM GÖ', 'İstanbul', 'Kadıköy', 5),
(408, '120.02.34.001', 'ÜÇGEN-İstanbul-Kağıthane-Ayışığı', 'İstanbul', 'Kağıthane', 5),
(409, '120.01.34.691', 'ÜÇGEN-İstanbul-Küçükçekmece-Gern', 'İstanbul', 'Küçükçekmece', 5),
(410, '120.02.34.066', 'ÜÇGEN-İstanbul-Maltepe-Kitaplar ', 'İstanbul', 'Maltepe', 5),
(411, '120.02.34.082', 'ÜÇGEN-İstanbul-Pendik-Bilen Kita', 'İstanbul', 'Pendik', 5),
(412, '120.02.34.013', 'ÜÇGEN-İstanbul-Sancaktepe-Hüseyi', 'İstanbul', 'Sancaktepe', 5),
(413, '120.01.34.560', 'ÜÇGEN-İstanbul-Sarıyer-Kartal Ya', 'İstanbul', 'Sarıyer', 5),
(414, '120.01.34.088', 'ÜÇGEN-İstanbul-Silivri-Ozan Kırt', 'İstanbul', 'Silivri', 5),
(415, '120.01.34.609', 'ÜÇGEN-İstanbul-Sultanbeyli-Eylül', 'İstanbul', 'Sultanbeyli', 5),
(416, '120.01.34.040', 'ÜÇGEN-İstanbul-Sultangazi-Efe Kı', 'İstanbul', 'Sultangazi', 5),
(417, '120.01.34.041', 'ÜÇGEN-İstanbul-Sultangazi-Enar K', 'İstanbul', 'Sultangazi', 5),
(418, '120.01.34.122', 'ÜÇGEN-İstanbul-Sultangazi-Üstün ', 'İstanbul', 'Sultangazi', 5),
(419, '120.02.34.010', 'ÜÇGEN-İstanbul-Tuzla-Emir Ajans ', 'İstanbul', 'Tuzla', 5),
(420, '120.02.34.023', 'ÜÇGEN-İstanbul-Ümraniye-Okuyan A', 'İstanbul', 'Ümraniye', 5),
(421, '120.02.34.088', 'ÜÇGEN-İstanbul-Ümraniye-Ebruli Y', 'İstanbul', 'Ümraniye', 5),
(422, '120.02.34.094', 'ÜÇGEN-İstanbul-Üsküdar-Burak Kit', 'İstanbul', 'Üsküdar', 5),
(423, '120.01.34.167', 'ÜÇGEN-İstanbul-Zeytinburnu-Kafda', 'İstanbul', 'Zeytinburnu', 5),
(424, '120.05.35.001', 'ÜÇGEN-İzmir-Aliağa-Bahar Yayın D', 'İzmir', 'Aliağa', 5),
(425, '120.05.35.003', 'ÜÇGEN-İzmir-Balçova-Sır Yayın Da', 'İzmir', 'Balçova', 5),
(426, '120.05.35.005', 'ÜÇGEN-İzmir-Bornova-Ahmet Aslan', 'İzmir', 'Bornova', 5),
(427, '120.05.35.152', 'ÜÇGEN-İzmir-Buca-AHMET SAKİN', 'İzmir', 'Buca', 5),
(428, '120.05.35.027', 'ÜÇGEN-İzmir-Menemen-Ezgi Kırtasi', 'İzmir', 'Menemen', 5),
(429, '120.05.35.029', 'ÜÇGEN-İzmir-Ödemiş-Elpa Kitap Kı', 'İzmir', 'Ödemiş', 5),
(430, '120.05.35.154', 'ÜÇGEN-İzmir-Tire-Kardaşım Kırtas', 'İzmir', 'Tire', 5),
(431, '120.06.46.022', 'ÜÇGEN-Kahramanmaraş-Elbistan-Işı', 'Kahramanmaraş', 'Elbistan', 5),
(432, '120.06.46.012', 'ÜÇGEN-Kahramanmaraş-Göksun-Tanır', 'Kahramanmaraş', 'Göksun', 5),
(433, '120.06.46.014', 'ÜÇGEN-Kahramanmaraş-Pazarcık-Kıs', 'Kahramanmaraş', 'Pazarcık', 5),
(434, '120.10.78.001', 'ÜÇGEN-Karabük-Safranbolu-Arkadaş', 'Karabük', 'Safranbolu', 5),
(435, '120.07.70.001', 'ÜÇGEN-Karaman-Merkez-Danış Kitab', 'Karaman', 'Merkez', 5),
(436, '120.09.36.003', 'ÜÇGEN-Kars-Sarıkamış-İlk Kitap K', 'Kars', 'Sarıkamış', 5),
(437, '120.10.37.002', 'ÜÇGEN-Kastamonu-Merez-Sancak Kit', 'Kastamonu', 'Merez', 5),
(438, '120.08.38.005', 'ÜÇGEN-Kayseri-Kocasinan-Erdem Ki', 'Kayseri', 'Kocasinan', 5),
(439, '120.08.38.015', 'ÜÇGEN-Kayseri-Pınarbaşı-Kevser K', 'Kayseri', 'Pınarbaşı', 5),
(440, '120.08.71.001', 'ÜÇGEN-Kırıkkale-Keskin-Efe Kitap', 'Kırıkkale', 'Keskin', 5),
(441, '120.03.39.008', 'ÜÇGEN-Kırklareli-Lüleburgaz-Şent', 'Kırklareli', 'Lüleburgaz', 5),
(442, '120.03.39.011', 'ÜÇGEN-Kırklareli-Merkez-Çınar Kı', 'Kırklareli', 'Merkez', 5),
(443, '120.08.40.002', 'ÜÇGEN-Kırşehir-Kaman-Güven Kırta', 'Kırşehir', 'Kaman', 5),
(444, '120.08.40.011', 'ÜÇGEN-Kırşehir-Merkez-Altın Kit.', 'Kırşehir', 'Merkez', 5),
(445, '120.04.41.002', 'ÜÇGEN-Kocaeli-Derince-Metin Kırt', 'Kocaeli', 'Derince', 5),
(446, '120.04.41.004', 'ÜÇGEN-Kocaeli-Gebze-Ercan Kırtas', 'Kocaeli', 'Gebze', 5),
(447, '120.04.41.011', 'ÜÇGEN-Kocaeli-Gölcük-Elif Kitape', 'Kocaeli', 'Gölcük', 5),
(448, '120.04.41.016', 'ÜÇGEN-Kocaeli-İzmit-Eylül Kırtas', 'Kocaeli', 'İzmit', 5),
(449, '120.07.42.036', 'ÜÇGEN-Konya-Akşehir-Öğrenci  Kır', 'Konya', 'Akşehir', 5),
(450, '120.07.42.006', 'ÜÇGEN-Konya-Beyşehir-Öykü Kit. K', 'Konya', 'Beyşehir', 5),
(451, '120.07.42.044', 'ÜÇGEN-Konya-Ereğli-Cem Kırt. - M', 'Konya', 'Ereğli', 5),
(452, '120.07.42.008', 'ÜÇGEN-Konya-Ilgın-Barış Kırtasiy', 'Konya', 'Ilgın', 5),
(453, '120.07.42.030', 'ÜÇGEN-Konya-Karapınar-Elfida Kit', 'Konya', 'Karapınar', 5),
(454, '120.07.42.038', 'ÜÇGEN-Konya-Meram-Farklı Kitabev', 'Konya', 'Meram', 5),
(455, '120.07.42.027', 'ÜÇGEN-Konya-Seydişehir-Meydan Kı', 'Konya', 'Seydişehir', 5),
(456, '120.05.43.003', 'ÜÇGEN-Kütahya-Gediz-Sistem Kırta', 'Kütahya', 'Gediz', 5),
(457, '120.05.43.007', 'ÜÇGEN-Kütahya-Merkez-Zirve Kırta', 'Kütahya', 'Merkez', 5),
(458, '120.05.43.009', 'ÜÇGEN-Kütahya-Simav-Eğitim Kırt.', 'Kütahya', 'Simav', 5),
(459, '120.09.44.010', 'ÜÇGEN-Malatya-Battalgazi-Koza Ya', 'Malatya', 'Battalgazi', 5),
(460, '120.05.45.002', 'ÜÇGEN-Manisa-Akhisar-Köşkler Kır', 'Manisa', 'Akhisar', 5),
(461, '120.05.45.004', 'ÜÇGEN-Manisa-Alaşehir-Bilge Kita', 'Manisa', 'Alaşehir', 5),
(462, '120.05.45.005', 'ÜÇGEN-Manisa-Demirci-Tunalılar K', 'Manisa', 'Demirci', 5),
(463, '120.05.45.013', 'ÜÇGEN-Manisa-Gördes-Ege Kırtasiy', 'Manisa', 'Gördes', 5),
(464, '120.05.45.014', 'ÜÇGEN-Manisa-Kırkağaç-Yağmur Kır', 'Manisa', 'Kırkağaç', 5),
(465, '120.05.45.025', 'ÜÇGEN-Manisa-Salihli-Papirüs  Ki', 'Manisa', 'Salihli', 5),
(466, '120.05.45.012', 'ÜÇGEN-Manisa-Yunusemre-Ersen Kit', 'Manisa', 'Yunusemre', 5),
(467, '120.12.47.024', 'ÜÇGEN-Mardin-Dargeçit-Artuklu Ki', 'Mardin', 'Dargeçit', 5),
(468, '120.12.47.013', 'ÜÇGEN-Mardin-Kızıltepe-Turunç Ki', 'Mardin', 'Kızıltepe', 5),
(469, '120.12.47.019', 'ÜÇGEN-Mardin-Midyat-Taksan İnş.İ', 'Mardin', 'Midyat', 5),
(470, '120.06.33.002', 'ÜÇGEN-Mersin(içel)-Akdeniz-Mersi', 'Mersin(içel)', 'Akdeniz', 5),
(471, '120.06.33.003', 'ÜÇGEN-Mersin(içel)-Anamur-Aytaç ', 'Mersin(içel)', 'Anamur', 5),
(472, '120.06.33.029', 'ÜÇGEN-Mersin(içel)-Erdemli-Pakso', 'Mersin(içel)', 'Erdemli', 5),
(473, '120.06.33.010', 'ÜÇGEN-Mersin(içel)-Mut-Turkuaz K', 'Mersin(içel)', 'Mut', 5),
(474, '120.06.33.012', 'ÜÇGEN-Mersin(içel)-Silifke-Mt Da', 'Mersin(içel)', 'Silifke', 5),
(475, '120.06.33.025', 'ÜÇGEN-Mersin(içel)-Tarsus-Akkuş ', 'Mersin(içel)', 'Tarsus', 5),
(476, '120.05.48.002', 'ÜÇGEN-Muğla-Bodrum-Prıncess Dağı', 'Muğla', 'Bodrum', 5),
(477, '120.05.48.006', 'ÜÇGEN-Muğla-Fethiye-Fethiye Abc ', 'Muğla', 'Fethiye', 5),
(478, '120.05.48.011', 'ÜÇGEN-Muğla-Marmaris-Marmaris Ki', 'Muğla', 'Marmaris', 5),
(479, '120.05.48.030', 'ÜÇGEN-Muğla-Merkez-Muğla Eray Ar', 'Muğla', 'Merkez', 5),
(480, '120.05.48.022', 'ÜÇGEN-Muğla-Milas-Aşkın Kırtasiy', 'Muğla', 'Milas', 5),
(481, '120.05.48.025', 'ÜÇGEN-Muğla-Ortaca-Ortaca Eray K', 'Muğla', 'Ortaca', 5),
(482, '120.09.49.009', 'ÜÇGEN-Muş-Bulanık-Dilan Kırt. - ', 'Muş', 'Bulanık', 5),
(483, '120.09.49.003', 'ÜÇGEN-Muş-Merkez-Ay-Ka Kitap Kır', 'Muş', 'Merkez', 5),
(484, '120.08.50.001', 'ÜÇGEN-Nevşehir-Avanos-Öykü Kırta', 'Nevşehir', 'Avanos', 5),
(485, '120.08.50.006', 'ÜÇGEN-Nevşehir-Kozaklı-Yunus Emr', 'Nevşehir', 'Kozaklı', 5),
(486, '120.08.51.003', 'ÜÇGEN-Niğde-Merkez-YUNUS BATU', 'Niğde', 'Merkez', 5),
(487, '120.11.52.001', 'ÜÇGEN-Ordu-Altınordu-Efe Kitabev', 'Ordu', 'Altınordu', 5),
(488, '120.11.52.020', 'ÜÇGEN-Ordu-Fatsa-Özgen Kitapevi ', 'Ordu', 'Fatsa', 5),
(489, '120.11.52.015', 'ÜÇGEN-Ordu-Ünye-Hece Kitap Kırt.', 'Ordu', 'Ünye', 5),
(490, '120.06.80.018', 'ÜÇGEN-Osmaniye-Düziçi-Polen Yay.', 'Osmaniye', 'Düziçi', 5),
(491, '120.06.80.014', 'ÜÇGEN-Osmaniye-Kadirli-Çamlık Ki', 'Osmaniye', 'Kadirli', 5),
(492, '120.06.80.016', 'ÜÇGEN-Osmaniye-Merkez-Yeni Boğaz', 'Osmaniye', 'Merkez', 5),
(493, '120.11.53.015', 'ÜÇGEN-Rize-Ardeşen-Dk Kit.Kırt. ', 'Rize', 'Ardeşen', 5),
(494, '120.11.53.011', 'ÜÇGEN-Rize-Merkez-Çemberci Kit.K', 'Rize', 'Merkez', 5),
(495, '120.04.54.023', 'ÜÇGEN-Sakarya-Adapazarı-ADA BARI', 'Sakarya', 'Adapazarı', 5),
(496, '120.10.55.025', 'ÜÇGEN-Samsun-Bafra-Elif Kırtasiy', 'Samsun', 'Bafra', 5),
(497, '120.10.55.041', 'ÜÇGEN-Samsun-Havza-Akay Kırt. - ', 'Samsun', 'Havza', 5),
(498, '120.10.55.039', 'ÜÇGEN-Samsun-İlkadım-Selamet Kit', 'Samsun', 'İlkadım', 5),
(499, '120.10.55.018', 'ÜÇGEN-Samsun-Ladik-Kümes Hayvanl', 'Samsun', 'Ladik', 5),
(500, '120.10.55.023', 'ÜÇGEN-Samsun-Terme-ONUR ERSOY', 'Samsun', 'Terme', 5),
(501, '120.12.56.010', 'ÜÇGEN-Siirt-Merkez-Yayın Bahçesi', 'Siirt', 'Merkez', 5),
(502, '120.10.57.001', 'ÜÇGEN-Sinop-Ayancık-Güven Kırtas', 'Sinop', 'Ayancık', 5),
(503, '120.10.57.007', 'ÜÇGEN-Sinop-Merkez-Seçil Kırtasi', 'Sinop', 'Merkez', 5),
(504, '120.08.58.004', 'ÜÇGEN-Sivas-Gölova-Sivas Kitap C', 'Sivas', 'Gölova', 5),
(505, '120.12.63.001', 'ÜÇGEN-Şanlıurfa-Birecik-Köprü Kı', 'Şanlıurfa', 'Birecik', 5),
(506, '120.12.63.013', 'ÜÇGEN-Şanlıurfa-Siverek-Akademi ', 'Şanlıurfa', 'Siverek', 5),
(507, '120.12.63.016', 'ÜÇGEN-Şanlıurfa-Viranşehir-Yavuz', 'Şanlıurfa', 'Viranşehir', 5),
(508, '120.12.63.019', 'ÜÇGEN-Şanlıurfa-Viranşehir-Fener', 'Şanlıurfa', 'Viranşehir', 5),
(509, '120.13.01.001', 'ÜÇGEN-Şehir-İlçe-Gülver Ticaret ', 'Şehir', 'İlçe', 5),
(510, '120.03.59.013', 'ÜÇGEN-Tekirdağ-Hayrabolu-Oya Kır', 'Tekirdağ', 'Hayrabolu', 5),
(511, '120.03.59.020', 'ÜÇGEN-Tekirdağ-Merkez-Gülhan Kit', 'Tekirdağ', 'Merkez', 5),
(512, '120.10.60.006', 'ÜÇGEN-Tokat-Merkez-Çizgi Kitap K', 'Tokat', 'Merkez', 5),
(513, '120.11.61.001', 'ÜÇGEN-Trabzon-Akçaabat-Oskar Kit', 'Trabzon', 'Akçaabat', 5),
(514, '120.11.61.015', 'ÜÇGEN-Trabzon-Merkez-Anka Kitap ', 'Trabzon', 'Merkez', 5),
(515, '120.09.62.003', 'ÜÇGEN-Tunceli-Merkez-Seçkin Kırt', 'Tunceli', 'Merkez', 5),
(516, '120.05.64.004', 'ÜÇGEN-Uşak-Merkez-Özgür Alakent ', 'Uşak', 'Merkez', 5),
(517, '120.09.65.001', 'ÜÇGEN-Van-Erciş-Emek Kırtasiye -', 'Van', 'Erciş', 5),
(518, '120.09.65.010', 'ÜÇGEN-Van-Merkez-Ceren Kit.Kırt.', 'Van', 'Merkez', 5),
(519, '120.04.77.004', 'ÜÇGEN-Yalova-Merkez-Yalova Kültü', 'Yalova', 'Merkez', 5),
(520, '120.08.66.005', 'ÜÇGEN-Yozgat-Sorgun-Gazihan Kırt', 'Yozgat', 'Sorgun', 5),
(521, '120.08.66.008', 'ÜÇGEN-Yozgat-Yerköy-Dk Dört Kale', 'Yozgat', 'Yerköy', 5),
(522, '120.10.67.004', 'ÜÇGEN-Zonguldak-Çaycuma-Köktürk ', 'Zonguldak', 'Çaycuma', 5),
(523, '120.10.67.006', 'ÜÇGEN-Zonguldak-Devrek-Uğur Kita', 'Zonguldak', 'Devrek', 5),
(524, '120.10.67.008', 'ÜÇGEN-Zonguldak-Ereğli-Kdz.Ereğl', 'Zonguldak', 'Ereğli', 5),
(525, 'KB-1237', 'KB-BURSA-Osmangazi-SENTEZ', 'BURSA', 'Osmangazi', 6),
(526, 'KB-1388', 'KB-ESKİŞEHİR-Tepebaşı-ATAK', 'ESKİŞEHİR', 'Tepebaşı', 6),
(527, 'KB-1182', 'KB-BİLECİK-Merkez-ATAK', 'BİLECİK', 'Merkez', 6),
(528, 'KB-1746-1', 'KB-MUĞLA-Fethiye-İKLİM', 'BİLECİK', 'Merkez', 6),
(529, 'M-1237', 'M-BURSA-Osmangazi-BİLGİN', 'BURSA', 'Osmangazi', 6),
(530, 'KB-1524-1', 'ER-İZMİR-Ödemiş-EROL', 'İZMİR', 'Ödemiş', 6),
(531, 'ER-1530', 'ER-KAHRAMANMARAŞ-Afşin-ATILIM', 'KAHRAMANMARAŞ', 'Afşin', 2),
(532, 'ER-1996', 'ER-ZONGULDAK-Çaycuma-LEVENT', 'ZONGULDAK', 'Çaycuma', 2),
(533, 'M-1008', 'M-ADANA-Kozan-FURKAN', 'ADANA', 'KOZAN', 6);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_branslar_tbl`
--

CREATE TABLE `sis_branslar_tbl` (
  `id` int(11) NOT NULL,
  `branskodu` int(8) NOT NULL,
  `bransadi` varchar(64) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_branslar_tbl`
--

INSERT INTO `sis_branslar_tbl` (`id`, `branskodu`, `bransadi`) VALUES
(1, 1, 'Sınıf Öğretmeni'),
(2, 2, 'Türkçe Öğretmeni'),
(3, 3, 'Matematik Öğretmeni'),
(4, 4, 'Hayat Bilgisi Öğretmeni'),
(5, 5, 'Fen Bilimleri Öğretmeni'),
(6, 6, 'Sosyal Bilgiler Öğretmeni'),
(7, 7, 'T.C.İnkılâp Tarihi ve Atatürkçülük Öğretmeni'),
(8, 8, 'İngilizce Öğretmeni'),
(9, 9, 'Din Kültürü ve Ahlâk Bilgisi Öğretmeni'),
(10, 10, 'Görsel Sanatlar Öğretmeni'),
(11, 11, 'Müzik Öğretmeni'),
(12, 12, 'Beden Eğitimi ve Spor Öğretmeni'),
(13, 13, 'Teknoloji ve Tasarım Öğretmeni'),
(14, 14, 'Trafik Güvenliği Öğretmeni'),
(15, 15, 'Rehberlik ve Kariyer Planlama Öğretmeni'),
(16, 16, 'Bilişim Teknelojileri ve Yazılım Öğretmeni'),
(17, 17, 'İnsan Hakları, Yurttaşlık ve Demokrasi Öğretmeni'),
(18, 18, 'Okul Müdürü'),
(19, 19, 'Müdür Yardımcısı'),
(20, 20, 'Şube Müdürü'),
(21, 21, 'Uzman Öğretmen'),
(22, 22, 'Okul Öncesi Öğretmeni'),
(23, 23, 'Özel Eğitim Sınıfı Öğretmeni');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_defterler_tbl`
--

CREATE TABLE `sis_defterler_tbl` (
  `id` int(11) NOT NULL,
  `yil` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `defterkodu` int(8) NOT NULL,
  `defteradi` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `sayfasayisi` int(4) NOT NULL,
  `sinif` varchar(32) COLLATE utf8_turkish_ci NOT NULL,
  `derssayisi` int(2) DEFAULT NULL,
  `ozellik` varchar(32) COLLATE utf8_turkish_ci NOT NULL,
  `kapak` varchar(32) COLLATE utf8_turkish_ci NOT NULL,
  `ogrencilisteli` tinyint(1) NOT NULL DEFAULT '0',
  `grup1` double NOT NULL,
  `grup2` double NOT NULL,
  `grup3` double NOT NULL,
  `grup4` double NOT NULL,
  `grup5` double NOT NULL,
  `grup6` double NOT NULL,
  `grup7` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_defterler_tbl`
--

INSERT INTO `sis_defterler_tbl` (`id`, `yil`, `defterkodu`, `defteradi`, `sayfasayisi`, `sinif`, `derssayisi`, `ozellik`, `kapak`, `ogrencilisteli`, `grup1`, `grup2`, `grup3`, `grup4`, `grup5`, `grup6`, `grup7`) VALUES
(1, '2022-2023', 101, 'Kurs Defteri', 56, 'Tüm Sınıflar', 8, 'Yoklamalı', 'PP', 0, 7, 10, 10, 10, 10, 10, 10),
(2, '2022-2023', 151, 'Okul Öncesi Defteri', 56, 'Ana Sınıfı', 6, 'Yoklamalı', 'PP', 0, 7, 10, 10, 10, 10, 10, 10),
(3, '2022-2023', 161, 'Sınıf Defteri', 58, '1-2-3-4', 6, 'Yoklamalı', 'PP', 0, 7, 10, 10, 10, 10, 10, 10),
(4, '2022-2023', 171, 'Ders Defteri', 84, '5-6-7-8', 7, 'Yoklamalı', 'PP', 0, 8, 11, 11, 11, 11, 11, 11),
(5, '2022-2023', 172, 'Ders Defteri', 84, '5-6-7-8', 7, 'Yoklamasız', 'PP', 0, 8, 11, 11, 11, 11, 11, 11),
(6, '2022-2023', 181, 'Ders Defteri', 84, '5-6-7-8-9-10-11-12', 8, 'Yoklamalı', 'PP', 0, 8, 11, 11, 11, 11, 11, 11),
(7, '2022-2023', 182, 'Ders Defteri', 84, '5-6-7-8-9-10-11-12', 8, 'Yoklamasız', 'PP', 0, 8, 11, 11, 11, 11, 11, 11),
(8, '2022-2023', 191, 'Ders Defteri', 84, '9-10-11-12', 10, 'Yoklamalı', 'PP', 0, 8, 11, 11, 11, 11, 11, 11),
(9, '2022-2023', 192, 'Ders Defteri', 84, '9-10-11-12', 10, 'Yoklamasız', 'PP', 0, 8, 11, 11, 11, 11, 11, 11),
(10, '2022-2023', 201, 'Kurs Defteri', 56, 'Tüm Sınıflar', 8, 'Yoklamalı', 'İMPRTKS', 0, 11, 14, 14, 14, 14, 14, 14),
(11, '2022-2023', 251, 'Okul Öncesi Defteri', 56, 'Ana Sınıfı', 6, 'Yoklamalı', 'İMPRTKS', 0, 11, 14, 14, 14, 14, 14, 14),
(12, '2022-2023', 261, 'Sınıf Defteri', 58, '1-2-3-4', 6, 'Yoklamalı', 'İMPRTKS', 0, 11, 14, 14, 14, 14, 14, 14),
(13, '2022-2023', 271, 'Ders Defteri', 84, '5-6-7-8', 7, 'Yoklamalı', 'İMPRTKS', 0, 12, 15, 15, 15, 15, 15, 15),
(14, '2022-2023', 272, 'Ders Defteri', 84, '5-6-7-8', 7, 'Yoklamasız', 'İMPRTKS', 0, 12, 15, 15, 15, 15, 15, 15),
(15, '2022-2023', 281, 'Ders Defteri', 84, '5-6-7-8-9-10-11-12', 8, 'Yoklamalı', 'İMPRTKS', 0, 12, 15, 15, 15, 15, 15, 15),
(16, '2022-2023', 282, 'Ders Defteri', 84, '5-6-7-8-9-10-11-12', 8, 'Yoklamasız', 'İMPRTKS', 0, 12, 15, 15, 15, 15, 15, 15),
(17, '2022-2023', 291, 'Ders Defteri', 84, '9-10-11-12', 10, 'Yoklamalı', 'İMPRTKS', 0, 12, 15, 15, 15, 15, 15, 15),
(18, '2022-2023', 292, 'Ders Defteri', 84, '9-10-11-12', 10, 'Yoklamasız', 'İMPRTKS', 0, 12, 15, 15, 15, 15, 15, 15),
(19, '2022-2023', 301, 'Kurs Defteri', 56, 'Tüm Sınıflar', 8, 'Yoklamalı', 'PP', 0, 10, 13, 13, 13, 13, 13, 13),
(20, '2022-2023', 351, 'Okul Öncesi Defteri', 56, 'Ana Sınıfı', 6, 'Yoklamalı', 'PP', 0, 10, 13, 13, 13, 13, 13, 13),
(21, '2022-2023', 361, 'Sınıf Defteri', 58, '1-2-3-4', 6, 'Yoklamalı', 'PP', 0, 10, 13, 13, 13, 13, 13, 13),
(22, '2022-2023', 371, 'Ders Defteri', 84, '5-6-7-8', 7, 'Yoklamalı', 'PP', 0, 12, 15, 15, 15, 15, 15, 15),
(23, '2022-2023', 372, 'Ders Defteri', 84, '5-6-7-8', 7, 'Yoklamasız', 'PP', 0, 12, 15, 15, 15, 15, 15, 15),
(24, '2022-2023', 381, 'Ders Defteri', 84, '5-6-7-8-9-10-11-12', 8, 'Yoklamalı', 'PP', 0, 12, 15, 15, 15, 15, 15, 15),
(25, '2022-2023', 382, 'Ders Defteri', 84, '5-6-7-8-9-10-11-12', 8, 'Yoklamasız', 'PP', 0, 12, 15, 15, 15, 15, 15, 15),
(26, '2022-2023', 391, 'Ders Defteri', 84, '9-10-11-12', 10, 'Yoklamalı', 'PP', 0, 12, 15, 15, 15, 15, 15, 15),
(27, '2022-2023', 392, 'Ders Defteri', 84, '9-10-11-12', 10, 'Yoklamasız', 'PP', 0, 12, 15, 15, 15, 15, 15, 15),
(28, '2022-2023', 401, 'Kurs Defteri', 56, 'Tüm Sınıflar', 8, 'Yoklamalı', 'İMPRTKS', 0, 16, 20, 20, 20, 20, 20, 20),
(29, '2022-2023', 451, 'Okul Öncesi Defteri', 56, 'Ana Sınıfı', 6, 'Yoklamalı', 'İMPRTKS', 0, 16, 20, 20, 20, 20, 20, 20),
(30, '2022-2023', 461, 'Sınıf Defteri', 58, '1-2-3-4', 6, 'Yoklamalı', 'İMPRTKS', 0, 16, 20, 20, 20, 20, 20, 20),
(31, '2022-2023', 471, 'Ders Defteri', 84, '5-6-7-8', 7, 'Yoklamalı', 'İMPRTKS', 0, 18, 22, 22, 22, 22, 22, 22),
(32, '2022-2023', 472, 'Ders Defteri', 84, '5-6-7-8', 7, 'Yoklamasız', 'İMPRTKS', 0, 18, 22, 22, 22, 22, 22, 22),
(33, '2022-2023', 481, 'Ders Defteri', 84, '5-6-7-8-9-10-11-12', 8, 'Yoklamalı', 'İMPRTKS', 0, 18, 22, 22, 22, 22, 22, 22),
(34, '2022-2023', 482, 'Ders Defteri', 84, '5-6-7-8-9-10-11-12', 8, 'Yoklamasız', 'İMPRTKS', 0, 18, 22, 22, 22, 22, 22, 22),
(35, '2022-2023', 491, 'Ders Defteri', 84, '9-10-11-12', 10, 'Yoklamalı', 'İMPRTKS', 0, 18, 22, 22, 22, 22, 22, 22),
(36, '2022-2023', 492, 'Ders Defteri', 84, '9-10-11-12', 10, 'Yoklamasız', 'İMPRTKS', 0, 18, 22, 22, 22, 22, 22, 22),
(37, '2022-2023', 2608, 'Nöbet Defteri', 200, 'Tüm Sınıflar', 0, 'Normal Eğitim', 'İMPRTKS', 0, 25, 35, 35, 35, 35, 35, 35),
(38, '2022-2023', 2610, 'Nöbet Defteri', 200, 'Tüm Sınıflar', 0, 'Normal Eğitim', 'İMPRTKS', 0, 25, 35, 35, 35, 35, 35, 35),
(39, '2022-2023', 2612, 'Nöbet Defteri', 200, 'Tüm Sınıflar', 0, 'Normal Eğitim', 'İMPRTKS', 0, 25, 35, 35, 35, 35, 35, 35),
(40, '2022-2023', 2708, 'Nöbet Defteri', 200, 'Tüm Sınıflar', 0, 'Normal Eğitim', 'İMPRTKS', 0, 25, 35, 35, 35, 35, 35, 35),
(41, '2022-2023', 2710, 'Nöbet Defteri', 200, 'Tüm Sınıflar', 0, 'Normal Eğitim', 'İMPRTKS', 0, 25, 35, 35, 35, 35, 35, 35),
(42, '2022-2023', 2712, 'Nöbet Defteri', 200, 'Tüm Sınıflar', 0, 'Normal Eğitim', 'İMPRTKS', 0, 25, 35, 35, 35, 35, 35, 35),
(43, '2022-2023', 2808, 'Nöbet Defteri', 200, 'Tüm Sınıflar', 0, 'Normal Eğitim', 'İMPRTKS', 0, 25, 35, 35, 35, 35, 35, 35),
(44, '2022-2023', 2810, 'Nöbet Defteri', 200, 'Tüm Sınıflar', 0, 'Normal Eğitim', 'İMPRTKS', 0, 25, 35, 35, 35, 35, 35, 35),
(45, '2022-2023', 2812, 'Nöbet Defteri', 200, 'Tüm Sınıflar', 0, 'Normal Eğitim', 'İMPRTKS', 0, 25, 35, 35, 35, 35, 35, 35),
(46, '2022-2023', 2908, 'Nöbet Defteri', 200, 'Tüm Sınıflar', 0, 'Normal Eğitim', 'İMPRTKS', 0, 25, 35, 35, 35, 35, 35, 35),
(47, '2022-2023', 2910, 'Nöbet Defteri', 200, 'Tüm Sınıflar', 0, 'Normal Eğitim', 'İMPRTKS', 0, 25, 35, 35, 35, 35, 35, 35),
(48, '2022-2023', 2912, 'Nöbet Defteri', 200, 'Tüm Sınıflar', 0, 'Normal Eğitim', 'İMPRTKS', 0, 25, 35, 35, 35, 35, 35, 35),
(49, '2022-2023', 4608, 'Nöbet Defteri', 400, 'Tüm Sınıflar', 0, 'İkili Eğitim', 'İMPRTKS', 0, 40, 50, 50, 50, 50, 50, 50),
(50, '2022-2023', 4610, 'Nöbet Defteri', 400, 'Tüm Sınıflar', 0, 'İkili Eğitim', 'İMPRTKS', 0, 40, 50, 50, 50, 50, 50, 50),
(51, '2022-2023', 4612, 'Nöbet Defteri', 400, 'Tüm Sınıflar', 0, 'İkili Eğitim', 'İMPRTKS', 0, 40, 50, 50, 50, 50, 50, 50),
(52, '2022-2023', 4708, 'Nöbet Defteri', 400, 'Tüm Sınıflar', 0, 'İkili Eğitim', 'İMPRTKS', 0, 40, 50, 50, 50, 50, 50, 50),
(53, '2022-2023', 4710, 'Nöbet Defteri', 400, 'Tüm Sınıflar', 0, 'İkili Eğitim', 'İMPRTKS', 0, 40, 50, 50, 50, 50, 50, 50),
(54, '2022-2023', 4712, 'Nöbet Defteri', 400, 'Tüm Sınıflar', 0, 'İkili Eğitim', 'İMPRTKS', 0, 40, 50, 50, 50, 50, 50, 50),
(55, '2022-2023', 4808, 'Nöbet Defteri', 400, 'Tüm Sınıflar', 0, 'İkili Eğitim', 'İMPRTKS', 0, 40, 50, 50, 50, 50, 50, 50),
(56, '2022-2023', 4810, 'Nöbet Defteri', 400, 'Tüm Sınıflar', 0, 'İkili Eğitim', 'İMPRTKS', 0, 40, 50, 50, 50, 50, 50, 50),
(57, '2022-2023', 4812, 'Nöbet Defteri', 400, 'Tüm Sınıflar', 0, 'İkili Eğitim', 'İMPRTKS', 0, 40, 50, 50, 50, 50, 50, 50),
(58, '2022-2023', 4908, 'Nöbet Defteri', 400, 'Tüm Sınıflar', 0, 'İkili Eğitim', 'İMPRTKS', 0, 40, 50, 50, 50, 50, 50, 50),
(59, '2022-2023', 4910, 'Nöbet Defteri', 400, 'Tüm Sınıflar', 0, 'İkili Eğitim', 'İMPRTKS', 0, 40, 50, 50, 50, 50, 50, 50),
(60, '2022-2023', 4912, 'Nöbet Defteri', 400, 'Tüm Sınıflar', 0, 'İkili Eğitim', 'İMPRTKS', 0, 40, 50, 50, 50, 50, 50, 50);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_dersdagilim_gruplari`
--

CREATE TABLE `sis_dersdagilim_gruplari` (
  `id` int(11) NOT NULL,
  `yili` varchar(10) COLLATE utf8_turkish_ci NOT NULL,
  `dersgrubu1` int(6) NOT NULL,
  `dersgrubu2` int(6) NOT NULL,
  `dersgrubu3` int(6) NOT NULL,
  `dersgrubu4` int(6) NOT NULL,
  `dersgrubu5` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci COMMENT='Dersleri gruplandırıp illere göre tanımlayacağız.';

--
-- Tablo döküm verisi `sis_dersdagilim_gruplari`
--

INSERT INTO `sis_dersdagilim_gruplari` (`id`, `yili`, `dersgrubu1`, `dersgrubu2`, `dersgrubu3`, `dersgrubu4`, `dersgrubu5`) VALUES
(1, '2022-2023', 1022, 1022, 0, 0, 0),
(2, '2022-2023', 1031, 1032, 0, 0, 0),
(3, '2022-2023', 1041, 1042, 0, 0, 0),
(4, '2022-2023', 1051, 1051, 0, 0, 0),
(5, '2022-2023', 1061, 1061, 0, 0, 0),
(6, '2022-2023', 1071, 1071, 0, 0, 0),
(7, '2022-2023', 1201, 1201, 0, 0, 0),
(8, '2022-2023', 1202, 1202, 0, 0, 0),
(9, '2022-2023', 1203, 1203, 0, 0, 0),
(10, '2022-2023', 1204, 1204, 0, 0, 0),
(11, '2022-2023', 1205, 1205, 0, 0, 0),
(12, '2022-2023', 1206, 1206, 0, 0, 0),
(13, '2022-2023', 1207, 1207, 0, 0, 0),
(14, '2022-2023', 1208, 1208, 0, 0, 0),
(15, '2022-2023', 1209, 1209, 0, 0, 0),
(16, '2022-2023', 1210, 1210, 0, 0, 0),
(17, '2022-2023', 1211, 1211, 0, 0, 0),
(18, '2022-2023', 1212, 1212, 0, 0, 0),
(19, '2022-2023', 1213, 1213, 0, 0, 0),
(20, '2022-2023', 1214, 1214, 0, 0, 0),
(21, '2022-2023', 1215, 1215, 0, 0, 0),
(22, '2022-2023', 1216, 1216, 0, 0, 0),
(23, '2022-2023', 1217, 1217, 0, 0, 0),
(24, '2022-2023', 1218, 1218, 0, 0, 0),
(25, '2022-2023', 1219, 1219, 0, 0, 0),
(26, '2022-2023', 1220, 1220, 0, 0, 0),
(27, '2022-2023', 1221, 1221, 0, 0, 0),
(28, '2022-2023', 1222, 1222, 0, 0, 0),
(29, '2022-2023', 1223, 1223, 0, 0, 0),
(30, '2022-2023', 1224, 1224, 0, 0, 0),
(31, '2022-2023', 1225, 1225, 0, 0, 0),
(32, '2022-2023', 1226, 1226, 0, 0, 0),
(33, '2022-2023', 1227, 1227, 0, 0, 0),
(34, '2022-2023', 1228, 1228, 0, 0, 0),
(35, '2022-2023', 1229, 1229, 0, 0, 0),
(36, '2022-2023', 2021, 2022, 0, 0, 0),
(37, '2022-2023', 2032, 2032, 0, 0, 0),
(38, '2022-2023', 2041, 2042, 0, 0, 0),
(39, '2022-2023', 2051, 2051, 0, 0, 0),
(40, '2022-2023', 2061, 2061, 0, 0, 0),
(41, '2022-2023', 2071, 2071, 0, 0, 0),
(42, '2022-2023', 2081, 2081, 0, 0, 0),
(43, '2022-2023', 2201, 2201, 0, 0, 0),
(44, '2022-2023', 2202, 2202, 0, 0, 0),
(45, '2022-2023', 2203, 2203, 0, 0, 0),
(46, '2022-2023', 2204, 2204, 0, 0, 0),
(47, '2022-2023', 2205, 2205, 0, 0, 0),
(48, '2022-2023', 2206, 2206, 0, 0, 0),
(49, '2022-2023', 2207, 2207, 0, 0, 0),
(50, '2022-2023', 2208, 2208, 0, 0, 0),
(51, '2022-2023', 2209, 2209, 0, 0, 0),
(52, '2022-2023', 2210, 2210, 0, 0, 0),
(53, '2022-2023', 2211, 2211, 0, 0, 0),
(54, '2022-2023', 2212, 2212, 0, 0, 0),
(55, '2022-2023', 2213, 2213, 0, 0, 0),
(56, '2022-2023', 2214, 2214, 0, 0, 0),
(57, '2022-2023', 2215, 2215, 0, 0, 0),
(58, '2022-2023', 2216, 2216, 0, 0, 0),
(59, '2022-2023', 2217, 2217, 0, 0, 0),
(60, '2022-2023', 2218, 2218, 0, 0, 0),
(61, '2022-2023', 2219, 2219, 0, 0, 0),
(62, '2022-2023', 2220, 2220, 0, 0, 0),
(63, '2022-2023', 2221, 2221, 0, 0, 0),
(64, '2022-2023', 2222, 2222, 0, 0, 0),
(65, '2022-2023', 2223, 2223, 0, 0, 0),
(66, '2022-2023', 2224, 2224, 0, 0, 0),
(67, '2022-2023', 2225, 2225, 0, 0, 0),
(68, '2022-2023', 2226, 2226, 0, 0, 0),
(69, '2022-2023', 2227, 2227, 0, 0, 0),
(70, '2022-2023', 2228, 2228, 0, 0, 0),
(71, '2022-2023', 2229, 2229, 0, 0, 0),
(72, '2022-2023', 2230, 2230, 0, 0, 0),
(73, '2022-2023', 3011, 3012, 0, 0, 0),
(74, '2022-2023', 3021, 3022, 0, 0, 0),
(75, '2022-2023', 3031, 3032, 0, 0, 0),
(76, '2022-2023', 3041, 3042, 0, 0, 0),
(77, '2022-2023', 3051, 3051, 0, 0, 0),
(78, '2022-2023', 3061, 3061, 0, 0, 0),
(79, '2022-2023', 3071, 3071, 0, 0, 0),
(80, '2022-2023', 3081, 3081, 0, 0, 0),
(81, '2022-2023', 3201, 3201, 0, 0, 0),
(82, '2022-2023', 3202, 3202, 0, 0, 0),
(83, '2022-2023', 3203, 3203, 0, 0, 0),
(84, '2022-2023', 3204, 3204, 0, 0, 0),
(85, '2022-2023', 3205, 3205, 0, 0, 0),
(86, '2022-2023', 3206, 3206, 0, 0, 0),
(87, '2022-2023', 3207, 3207, 0, 0, 0),
(88, '2022-2023', 3208, 3208, 0, 0, 0),
(89, '2022-2023', 3209, 3209, 0, 0, 0),
(90, '2022-2023', 3210, 3210, 0, 0, 0),
(91, '2022-2023', 3211, 3211, 0, 0, 0),
(92, '2022-2023', 3212, 3212, 0, 0, 0),
(93, '2022-2023', 3213, 3213, 0, 0, 0),
(94, '2022-2023', 3214, 3214, 0, 0, 0),
(95, '2022-2023', 3215, 3215, 0, 0, 0),
(96, '2022-2023', 3216, 3216, 0, 0, 0),
(97, '2022-2023', 3217, 3217, 0, 0, 0),
(98, '2022-2023', 3218, 3218, 0, 0, 0),
(99, '2022-2023', 3219, 3219, 0, 0, 0),
(100, '2022-2023', 3220, 3220, 0, 0, 0),
(101, '2022-2023', 3221, 3221, 0, 0, 0),
(102, '2022-2023', 3222, 3222, 0, 0, 0),
(103, '2022-2023', 3223, 3223, 0, 0, 0),
(104, '2022-2023', 3224, 3224, 0, 0, 0),
(105, '2022-2023', 3225, 3225, 0, 0, 0),
(106, '2022-2023', 3226, 3226, 0, 0, 0),
(107, '2022-2023', 3227, 3227, 0, 0, 0),
(108, '2022-2023', 3228, 3228, 0, 0, 0),
(109, '2022-2023', 3229, 3229, 0, 0, 0),
(110, '2022-2023', 4011, 4012, 0, 0, 0),
(111, '2022-2023', 4022, 4022, 0, 0, 0),
(112, '2022-2023', 4031, 4032, 0, 0, 0),
(113, '2022-2023', 4041, 4042, 0, 0, 0),
(114, '2022-2023', 4051, 4051, 0, 0, 0),
(115, '2022-2023', 4061, 4061, 0, 0, 0),
(116, '2022-2023', 4071, 4071, 0, 0, 0),
(117, '2022-2023', 4081, 4081, 0, 0, 0),
(118, '2022-2023', 4091, 4091, 0, 0, 0),
(119, '2022-2023', 4101, 4101, 0, 0, 0),
(120, '2022-2023', 4111, 4111, 0, 0, 0),
(121, '2022-2023', 5011, 5011, 0, 0, 0),
(122, '2022-2023', 5021, 5021, 0, 0, 0),
(123, '2022-2023', 5032, 5032, 0, 0, 0),
(124, '2022-2023', 5041, 5041, 0, 0, 0),
(125, '2022-2023', 5051, 5051, 0, 0, 0),
(126, '2022-2023', 5061, 5061, 0, 0, 0),
(127, '2022-2023', 5071, 5071, 0, 0, 0),
(128, '2022-2023', 5081, 5081, 0, 0, 0),
(129, '2022-2023', 5091, 5091, 0, 0, 0),
(130, '2022-2023', 5101, 5101, 0, 0, 0),
(131, '2022-2023', 5201, 5201, 0, 0, 0),
(132, '2022-2023', 5204, 5204, 0, 0, 0),
(133, '2022-2023', 5206, 5206, 0, 0, 0),
(134, '2022-2023', 5207, 5207, 0, 0, 0),
(135, '2022-2023', 5209, 5209, 0, 0, 0),
(136, '2022-2023', 5211, 5211, 0, 0, 0),
(137, '2022-2023', 5212, 5212, 0, 0, 0),
(138, '2022-2023', 5214, 5214, 0, 0, 0),
(139, '2022-2023', 5215, 5215, 0, 0, 0),
(140, '2022-2023', 5216, 5216, 0, 0, 0),
(141, '2022-2023', 5217, 5217, 0, 0, 0),
(142, '2022-2023', 5218, 5218, 0, 0, 0),
(143, '2022-2023', 5219, 5219, 0, 0, 0),
(144, '2022-2023', 5220, 5220, 0, 0, 0),
(145, '2022-2023', 5221, 5221, 0, 0, 0),
(146, '2022-2023', 5222, 5222, 0, 0, 0),
(147, '2022-2023', 6011, 6011, 0, 0, 0),
(148, '2022-2023', 6021, 6021, 0, 0, 0),
(149, '2022-2023', 6031, 6032, 0, 0, 0),
(150, '2022-2023', 6041, 6041, 0, 0, 0),
(151, '2022-2023', 6051, 6051, 0, 0, 0),
(152, '2022-2023', 6061, 6061, 0, 0, 0),
(153, '2022-2023', 6071, 6071, 0, 0, 0),
(154, '2022-2023', 6081, 6081, 0, 0, 0),
(155, '2022-2023', 6091, 6091, 0, 0, 0),
(156, '2022-2023', 6101, 6101, 0, 0, 0),
(157, '2022-2023', 6201, 6201, 0, 0, 0),
(158, '2022-2023', 6204, 6204, 0, 0, 0),
(159, '2022-2023', 6206, 6206, 0, 0, 0),
(160, '2022-2023', 6207, 6207, 0, 0, 0),
(161, '2022-2023', 6208, 6208, 0, 0, 0),
(162, '2022-2023', 6209, 6209, 0, 0, 0),
(163, '2022-2023', 6211, 6211, 0, 0, 0),
(164, '2022-2023', 6212, 6212, 0, 0, 0),
(165, '2022-2023', 6214, 6214, 0, 0, 0),
(166, '2022-2023', 6215, 6215, 0, 0, 0),
(167, '2022-2023', 6216, 6216, 0, 0, 0),
(168, '2022-2023', 6217, 6217, 0, 0, 0),
(169, '2022-2023', 6218, 6218, 0, 0, 0),
(170, '2022-2023', 6219, 6219, 0, 0, 0),
(171, '2022-2023', 6220, 6220, 0, 0, 0),
(172, '2022-2023', 6221, 6221, 0, 0, 0),
(173, '2022-2023', 6222, 6222, 0, 0, 0),
(174, '2022-2023', 7011, 7011, 0, 0, 0),
(175, '2022-2023', 7021, 7021, 0, 0, 0),
(176, '2022-2023', 7031, 7032, 0, 0, 0),
(177, '2022-2023', 7041, 7041, 0, 0, 0),
(178, '2022-2023', 7051, 7051, 0, 0, 0),
(179, '2022-2023', 7061, 7061, 0, 0, 0),
(180, '2022-2023', 7071, 7071, 0, 0, 0),
(181, '2022-2023', 7081, 7081, 0, 0, 0),
(182, '2022-2023', 7091, 7091, 0, 0, 0),
(183, '2022-2023', 7111, 7111, 0, 0, 0),
(184, '2022-2023', 7201, 7201, 0, 0, 0),
(185, '2022-2023', 7202, 7202, 0, 0, 0),
(186, '2022-2023', 7203, 7203, 0, 0, 0),
(187, '2022-2023', 7205, 7205, 0, 0, 0),
(188, '2022-2023', 7206, 7206, 0, 0, 0),
(189, '2022-2023', 7207, 7207, 0, 0, 0),
(190, '2022-2023', 7208, 7208, 0, 0, 0),
(191, '2022-2023', 7209, 7209, 0, 0, 0),
(192, '2022-2023', 7210, 7210, 0, 0, 0),
(193, '2022-2023', 7211, 7211, 0, 0, 0),
(194, '2022-2023', 7212, 7212, 0, 0, 0),
(195, '2022-2023', 7213, 7213, 0, 0, 0),
(196, '2022-2023', 7214, 7214, 0, 0, 0),
(197, '2022-2023', 7216, 7216, 0, 0, 0),
(198, '2022-2023', 7217, 7217, 0, 0, 0),
(199, '2022-2023', 7218, 7218, 0, 0, 0),
(200, '2022-2023', 7219, 7219, 0, 0, 0),
(201, '2022-2023', 7220, 7220, 0, 0, 0),
(202, '2022-2023', 7221, 7221, 0, 0, 0),
(203, '2022-2023', 7222, 7222, 0, 0, 0),
(204, '2022-2023', 8011, 8011, 0, 0, 0),
(205, '2022-2023', 8021, 8021, 0, 0, 0),
(206, '2022-2023', 8031, 8031, 0, 0, 0),
(207, '2022-2023', 8041, 8041, 0, 0, 0),
(208, '2022-2023', 8051, 8051, 0, 0, 0),
(209, '2022-2023', 8061, 8061, 0, 0, 0),
(210, '2022-2023', 8071, 8071, 0, 0, 0),
(211, '2022-2023', 8081, 8081, 0, 0, 0),
(212, '2022-2023', 8091, 8091, 0, 0, 0),
(213, '2022-2023', 8111, 8111, 0, 0, 0),
(214, '2022-2023', 8121, 8121, 0, 0, 0),
(215, '2022-2023', 8161, 8161, 0, 0, 0),
(216, '2022-2023', 8201, 8201, 0, 0, 0),
(217, '2022-2023', 8202, 8202, 0, 0, 0),
(218, '2022-2023', 8203, 8203, 0, 0, 0),
(219, '2022-2023', 8205, 8205, 0, 0, 0),
(220, '2022-2023', 8206, 8206, 0, 0, 0),
(221, '2022-2023', 8207, 8207, 0, 0, 0),
(222, '2022-2023', 8209, 8209, 0, 0, 0),
(223, '2022-2023', 8210, 8210, 0, 0, 0),
(224, '2022-2023', 8211, 8211, 0, 0, 0),
(225, '2022-2023', 8212, 8212, 0, 0, 0),
(226, '2022-2023', 8213, 8213, 0, 0, 0),
(227, '2022-2023', 8214, 8214, 0, 0, 0),
(228, '2022-2023', 8216, 8216, 0, 0, 0),
(229, '2022-2023', 8217, 8217, 0, 0, 0),
(230, '2022-2023', 8218, 8218, 0, 0, 0),
(231, '2022-2023', 8219, 8219, 0, 0, 0),
(232, '2022-2023', 8220, 8220, 0, 0, 0),
(233, '2022-2023', 8221, 8221, 0, 0, 0),
(234, '2022-2023', 8222, 8222, 0, 0, 0),
(235, '2022-2023', 8223, 8223, 0, 0, 0);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_ekurunler_tbl`
--

CREATE TABLE `sis_ekurunler_tbl` (
  `id` int(11) NOT NULL,
  `yil` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `urunkodu` int(6) NOT NULL,
  `urunadi` varchar(32) COLLATE utf8_turkish_ci NOT NULL,
  `grup1` double NOT NULL,
  `grup2` double NOT NULL,
  `grup3` double NOT NULL,
  `grup4` double NOT NULL,
  `grup5` double NOT NULL,
  `grup6` double NOT NULL,
  `grup7` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_ekurunler_tbl`
--

INSERT INTO `sis_ekurunler_tbl` (`id`, `yil`, `urunkodu`, `urunadi`, `grup1`, `grup2`, `grup3`, `grup4`, `grup5`, `grup6`, `grup7`) VALUES
(2, '2022-2023', 102, 'PDF', 10, 10, 10, 10, 10, 10, 10);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_excel_bilgisutunlari_tbl`
--

CREATE TABLE `sis_excel_bilgisutunlari_tbl` (
  `id` int(11) NOT NULL,
  `bayikodu` int(3) NOT NULL,
  `aciklama` int(3) NOT NULL,
  `okulkodu` int(3) NOT NULL,
  `il` int(3) NOT NULL,
  `ilce` int(3) NOT NULL,
  `okuladi` int(3) NOT NULL,
  `sinif` int(3) NOT NULL,
  `sube` int(3) NOT NULL,
  `adisoyadi` int(3) NOT NULL,
  `gorevi` int(3) NOT NULL,
  `muduradi` int(3) NOT NULL,
  `mudurunvani` int(3) NOT NULL,
  `eposta` int(3) NOT NULL,
  `telefon` int(3) NOT NULL,
  `notumuz` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci COMMENT='Alanların excelde kaçıncı sütuna denk geldiğini tutan tablo.';

--
-- Tablo döküm verisi `sis_excel_bilgisutunlari_tbl`
--

INSERT INTO `sis_excel_bilgisutunlari_tbl` (`id`, `bayikodu`, `aciklama`, `okulkodu`, `il`, `ilce`, `okuladi`, `sinif`, `sube`, `adisoyadi`, `gorevi`, `muduradi`, `mudurunvani`, `eposta`, `telefon`, `notumuz`) VALUES
(1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 58);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_gunlukplandersler_tbl`
--

CREATE TABLE `sis_gunlukplandersler_tbl` (
  `id` int(11) NOT NULL,
  `yil` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `dersadi` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `dersid` int(8) NOT NULL,
  `bolum` int(4) NOT NULL,
  `grup1` double NOT NULL,
  `grup2` double NOT NULL,
  `grup3` double NOT NULL,
  `grup4` double NOT NULL,
  `grup5` double NOT NULL,
  `grup6` double NOT NULL,
  `grup7` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_gunlukplandersler_tbl`
--

INSERT INTO `sis_gunlukplandersler_tbl` (`id`, `yil`, `dersadi`, `dersid`, `bolum`, `grup1`, `grup2`, `grup3`, `grup4`, `grup5`, `grup6`, `grup7`) VALUES
(1, '2022-2023', '1-Görsel Sanatlar', 1061, 8, 9, 0, 0, 0, 0, 0, 0),
(2, '2022-2023', '1-Hayat Bilgisi-ARDIÇ', 1022, 2, 9, 0, 0, 0, 0, 0, 0),
(3, '2022-2023', '1-Matematik-MEB', 1041, 5, 9, 0, 0, 0, 0, 0, 0),
(4, '2022-2023', '1-Matematik-MHG', 1042, 6, 9, 0, 0, 0, 0, 0, 0),
(5, '2022-2023', '1-Müzik', 1071, 9, 9, 0, 0, 0, 0, 0, 0),
(6, '2022-2023', '1-Oyun ve Fiziki Etkinlikler', 1051, 7, 9, 0, 0, 0, 0, 0, 0),
(7, '2022-2023', '1-Türkçe-MEB', 1031, 3, 9, 0, 0, 0, 0, 0, 0),
(8, '2022-2023', '1-Türkçe-CEM', 1032, 4, 9, 0, 0, 0, 0, 0, 0),
(9, '2022-2023', '2-Görsel Sanatlar', 2061, 8, 9, 0, 0, 0, 0, 0, 0),
(10, '2022-2023', '2-Hayat Bilgisi-MEB', 2021, 2, 9, 0, 0, 0, 0, 0, 0),
(11, '2022-2023', '2-Hayat Bilgisi-BEŞGEN', 2022, 3, 9, 0, 0, 0, 0, 0, 0),
(12, '2022-2023', '2-Matematik-MEB', 2041, 5, 9, 0, 0, 0, 0, 0, 0),
(13, '2022-2023', '2-Matematik-TEKNO ARTI', 2042, 6, 9, 0, 0, 0, 0, 0, 0),
(14, '2022-2023', '2-Müzik', 2071, 9, 9, 0, 0, 0, 0, 0, 0),
(15, '2022-2023', '2-Oyun ve Fiziki Etkinlikler', 2051, 7, 9, 0, 0, 0, 0, 0, 0),
(16, '2022-2023', '2-Türkçe-KOZA', 2032, 4, 9, 0, 0, 0, 0, 0, 0),
(17, '2022-2023', '2-Yabancı Dil', 2081, 10, 0, 0, 0, 0, 0, 0, 0),
(18, '2022-2023', '3-Fen Bilimleri-MEB', 3011, 4, 9, 0, 0, 0, 0, 0, 0),
(19, '2022-2023', '3-Fen Bilimleri-TUNA', 3012, 5, 9, 0, 0, 0, 0, 0, 0),
(20, '2022-2023', '3-Görsel Sanatlar', 3061, 11, 9, 0, 0, 0, 0, 0, 0),
(21, '2022-2023', '3-Hayat Bilgisi-MEB', 3021, 2, 9, 0, 0, 0, 0, 0, 0),
(22, '2022-2023', '3-Hayat Bilgisi-EVREN', 3022, 3, 9, 0, 0, 0, 0, 0, 0),
(23, '2022-2023', '3-Matematik-MEB', 3041, 8, 9, 0, 0, 0, 0, 0, 0),
(24, '2022-2023', '3-Matematik-ADA', 3042, 9, 9, 0, 0, 0, 0, 0, 0),
(25, '2022-2023', '3-Müzik', 3071, 12, 9, 0, 0, 0, 0, 0, 0),
(26, '2022-2023', '3-Oyun ve Fiziki Etkinlikler', 3051, 10, 9, 0, 0, 0, 0, 0, 0),
(27, '2022-2023', '3-Türkçe-MEB', 3031, 6, 9, 0, 0, 0, 0, 0, 0),
(28, '2022-2023', '3-Türkçe-SONUÇ', 3032, 7, 9, 0, 0, 0, 0, 0, 0),
(29, '2022-2023', '3-Yabancı Dil', 3081, 13, 0, 0, 0, 0, 0, 0, 0),
(30, '2022-2023', '4-Din Kültürü ve Ahlak Bilgisi', 4091, 14, 0, 0, 0, 0, 0, 0, 0),
(31, '2022-2023', '4-Fen Bilimleri-MEB', 4011, 2, 8, 0, 0, 0, 0, 0, 0),
(32, '2022-2023', '4-Fen Bilimleri-SDRİPEKYOLU', 4012, 3, 8, 0, 0, 0, 0, 0, 0),
(33, '2022-2023', '4-Görsel Sanatlar', 4061, 12, 8, 0, 0, 0, 0, 0, 0),
(34, '2022-2023', '4-İnsan Hakları, Demokrasi ve Yurttaşlık', 4111, 10, 8, 0, 0, 0, 0, 0, 0),
(35, '2022-2023', '4-Matematik-MEB', 4041, 5, 8, 0, 0, 0, 0, 0, 0),
(36, '2022-2023', '4-Matematik-ATA', 4042, 6, 8, 0, 0, 0, 0, 0, 0),
(37, '2022-2023', '4-Müzik', 4071, 13, 8, 0, 0, 0, 0, 0, 0),
(38, '2022-2023', '4-Oyun ve Fiziki Etkinlikler', 4051, 11, 8, 0, 0, 0, 0, 0, 0),
(39, '2022-2023', '4-Sosyal Bilgiler-TUNA', 4022, 4, 8, 0, 0, 0, 0, 0, 0),
(40, '2022-2023', '4-Trafik Güvenliği', 4101, 9, 8, 0, 0, 0, 0, 0, 0),
(41, '2022-2023', '4-Türkçe-MEB', 4031, 7, 8, 0, 0, 0, 0, 0, 0),
(42, '2022-2023', '4-Türkçe-KOZA', 4032, 8, 8, 0, 0, 0, 0, 0, 0),
(43, '2022-2023', '4-Yabancı Dil', 4081, 15, 0, 0, 0, 0, 0, 0, 0),
(44, '2022-2023', '5-Beden Eğitimi ve Spor', 5051, 0, 20, 9, 10, 13, 15, 10, 0),
(45, '2022-2023', '5-Bilişim Teknolojileri ve Yazılım', 5101, 0, 20, 9, 10, 13, 15, 10, 0),
(46, '2022-2023', '5-Din Kültürü ve Ahlak Bilgisi', 5091, 0, 20, 9, 10, 13, 15, 10, 0),
(47, '2022-2023', '5-Fen Bilimleri', 5011, 2, 20, 9, 10, 13, 15, 10, 0),
(48, '2022-2023', '5-Görsel Sanatlar', 5061, 0, 20, 9, 10, 13, 15, 10, 0),
(49, '2022-2023', '5-Matematik', 5041, 3, 20, 9, 10, 13, 15, 10, 0),
(50, '2022-2023', '5-Müzik', 5071, 0, 20, 9, 10, 13, 15, 10, 0),
(51, '2022-2023', '5-Sosyal Bilgiler', 5021, 0, 20, 9, 10, 13, 15, 10, 0),
(52, '2022-2023', '5-Türkçe-MEB', 5031, 0, 20, 9, 10, 13, 15, 10, 0),
(53, '2022-2023', '5-Türkçe-ANITTEPE', 5032, 0, 20, 9, 10, 13, 15, 10, 0),
(54, '2022-2023', '5-Yabancı Dil', 5081, 4, 20, 9, 10, 13, 15, 10, 0),
(55, '2022-2023', '6-Beden Eğitimi ve Spor', 6051, 0, 20, 9, 10, 13, 15, 10, 0),
(56, '2022-2023', '6-Bilişim Teknolojileri ve Yazılım', 6101, 0, 20, 9, 10, 13, 15, 10, 0),
(57, '2022-2023', '6-Din Kültürü ve Ahlak Bilgisi', 6091, 0, 20, 9, 10, 13, 15, 10, 0),
(58, '2022-2023', '6-Fen Bilimleri', 6011, 2, 20, 9, 10, 13, 15, 10, 0),
(59, '2022-2023', '6-Görsel Sanatlar', 6061, 0, 20, 9, 10, 13, 15, 10, 0),
(60, '2022-2023', '6-Matematik', 6041, 3, 20, 9, 10, 13, 15, 10, 0),
(61, '2022-2023', '6-Müzik', 6071, 0, 20, 9, 10, 13, 15, 10, 0),
(62, '2022-2023', '6-Sosyal Bilgiler', 6021, 0, 20, 9, 10, 13, 15, 10, 0),
(63, '2022-2023', '6-Türkçe-MEB', 6031, 0, 20, 9, 10, 13, 15, 10, 0),
(64, '2022-2023', '6-Türkçe-EKOYAY', 6032, 0, 20, 9, 10, 13, 15, 10, 0),
(65, '2022-2023', '6-Yabancı Dil', 6081, 4, 20, 9, 10, 13, 15, 10, 0),
(66, '2022-2023', '7-Beden Eğitimi ve Spor', 7051, 0, 20, 9, 10, 13, 15, 10, 0),
(67, '2022-2023', '7-Din Kültürü ve Ahlak Bilgisi', 7091, 0, 20, 9, 10, 13, 15, 10, 0),
(68, '2022-2023', '7-Fen Bilimleri', 7011, 2, 20, 9, 10, 13, 15, 10, 0),
(69, '2022-2023', '7-Görsel Sanatlar', 7061, 0, 20, 9, 10, 13, 15, 10, 0),
(70, '2022-2023', '7-Matematik', 7041, 3, 20, 9, 10, 13, 15, 10, 0),
(71, '2022-2023', '7-Müzik', 7071, 0, 20, 9, 10, 13, 15, 10, 0),
(72, '2022-2023', '7-Sosyal Bilgiler', 7021, 0, 20, 9, 10, 13, 15, 10, 0),
(73, '2022-2023', '7-Teknoloji ve Tasarım', 7111, 0, 20, 9, 10, 13, 15, 10, 0),
(74, '2022-2023', '7-Türkçe-MEB-1', 7031, 0, 20, 9, 10, 13, 15, 10, 0),
(75, '2022-2023', '7-Türkçe-MEB-2', 7033, 0, 20, 9, 10, 13, 15, 10, 0),
(76, '2022-2023', '7-Türkçe-ÖZGÜN', 7032, 0, 20, 9, 10, 13, 15, 10, 0),
(77, '2022-2023', '7-Yabancı Dil', 7081, 4, 20, 9, 10, 13, 15, 10, 0),
(78, '2022-2023', '8-Beden Eğitimi ve Spor', 8051, 0, 20, 9, 10, 13, 15, 10, 0),
(79, '2022-2023', '8-Din Kültürü ve Ahlak Bilgisi', 8091, 0, 20, 9, 10, 13, 15, 10, 0),
(80, '2022-2023', '8-DÜŞÜNME EĞİTİMİ', 8205, 0, 20, 9, 10, 13, 15, 10, 0),
(81, '2022-2023', '8-Fen Bilimleri', 8011, 2, 20, 9, 10, 13, 15, 10, 0),
(82, '2022-2023', '8-Görsel Sanatlar', 8061, 0, 20, 9, 10, 13, 15, 10, 0),
(83, '2022-2023', '8-Matematik', 8041, 3, 20, 9, 10, 13, 15, 10, 0),
(84, '2022-2023', '8-Müzik', 8071, 0, 20, 9, 10, 13, 15, 10, 0),
(85, '2022-2023', '8-Rehberlik ve Sosyal Etkinlikler', 8121, 0, 20, 9, 10, 13, 15, 10, 0),
(86, '2022-2023', '8-TC İnkılap Tarihi ve Atatürkçülük', 8021, 0, 20, 9, 10, 13, 15, 10, 0),
(87, '2022-2023', '8-Teknoloji ve Tasarım', 8111, 0, 20, 9, 10, 13, 15, 10, 0),
(88, '2022-2023', '8-Türkçe-MEB', 8031, 0, 20, 9, 10, 13, 15, 10, 0),
(89, '2022-2023', '8-Yabancı Dil', 8081, 4, 20, 9, 10, 13, 15, 10, 0);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_ildersleri_tbl`
--

CREATE TABLE `sis_ildersleri_tbl` (
  `id` int(11) NOT NULL,
  `ilkodu` smallint(8) NOT NULL,
  `yili` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `dersgrubu` smallint(2) NOT NULL COMMENT 'ildeki derslerin ders dagilim grubu'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_ildersleri_tbl`
--

INSERT INTO `sis_ildersleri_tbl` (`id`, `ilkodu`, `yili`, `dersgrubu`) VALUES
(1, 1, '2022-2023', 1),
(2, 2, '2022-2023', 2),
(3, 3, '2022-2023', 2),
(4, 4, '2022-2023', 2),
(5, 5, '2022-2023', 2),
(6, 6, '2022-2023', 1),
(7, 7, '2022-2023', 2),
(8, 8, '2022-2023', 2),
(9, 9, '2022-2023', 2),
(10, 10, '2022-2023', 2),
(11, 11, '2022-2023', 2),
(12, 12, '2022-2023', 2),
(13, 13, '2022-2023', 2),
(14, 14, '2022-2023', 2),
(15, 15, '2022-2023', 2),
(16, 16, '2022-2023', 1),
(17, 17, '2022-2023', 2),
(18, 18, '2022-2023', 2),
(19, 19, '2022-2023', 2),
(20, 20, '2022-2023', 2),
(21, 21, '2022-2023', 2),
(22, 22, '2022-2023', 2),
(23, 23, '2022-2023', 2),
(24, 24, '2022-2023', 2),
(25, 25, '2022-2023', 2),
(26, 26, '2022-2023', 1),
(27, 27, '2022-2023', 2),
(28, 28, '2022-2023', 2),
(29, 29, '2022-2023', 2),
(30, 30, '2022-2023', 2),
(31, 31, '2022-2023', 2),
(32, 32, '2022-2023', 2),
(33, 33, '2022-2023', 2),
(34, 34, '2022-2023', 2),
(35, 35, '2022-2023', 2),
(36, 36, '2022-2023', 2),
(37, 37, '2022-2023', 2),
(38, 38, '2022-2023', 2),
(39, 39, '2022-2023', 2),
(40, 40, '2022-2023', 2),
(41, 41, '2022-2023', 2),
(42, 42, '2022-2023', 1),
(43, 43, '2022-2023', 2),
(44, 44, '2022-2023', 2),
(45, 45, '2022-2023', 2),
(46, 46, '2022-2023', 2),
(47, 47, '2022-2023', 2),
(48, 48, '2022-2023', 2),
(49, 49, '2022-2023', 2),
(50, 50, '2022-2023', 2),
(51, 51, '2022-2023', 2),
(52, 52, '2022-2023', 2),
(53, 53, '2022-2023', 2),
(54, 54, '2022-2023', 2),
(55, 55, '2022-2023', 2),
(56, 56, '2022-2023', 2),
(57, 57, '2022-2023', 2),
(58, 58, '2022-2023', 2),
(59, 59, '2022-2023', 2),
(60, 60, '2022-2023', 2),
(61, 61, '2022-2023', 2),
(62, 62, '2022-2023', 2),
(63, 63, '2022-2023', 2),
(64, 64, '2022-2023', 2),
(65, 65, '2022-2023', 2),
(66, 66, '2022-2023', 2),
(67, 67, '2022-2023', 2),
(68, 68, '2022-2023', 2),
(69, 69, '2022-2023', 2),
(70, 70, '2022-2023', 2),
(71, 71, '2022-2023', 2),
(72, 72, '2022-2023', 2),
(73, 73, '2022-2023', 2),
(74, 74, '2022-2023', 2),
(75, 75, '2022-2023', 2),
(76, 76, '2022-2023', 2),
(77, 77, '2022-2023', 2),
(78, 78, '2022-2023', 2),
(79, 79, '2022-2023', 2),
(80, 80, '2022-2023', 2),
(81, 81, '2022-2023', 2);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_iller_tbl`
--

CREATE TABLE `sis_iller_tbl` (
  `id` int(11) NOT NULL,
  `ilkodu` int(11) NOT NULL COMMENT 'plaka',
  `iladi` varchar(64) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_iller_tbl`
--

INSERT INTO `sis_iller_tbl` (`id`, `ilkodu`, `iladi`) VALUES
(1, 1, 'ADANA'),
(2, 2, 'ADIYAMAN'),
(3, 3, 'AFYONKARAHİSAR'),
(4, 4, 'AĞRI'),
(5, 5, 'AMASYA'),
(6, 6, 'ANKARA'),
(7, 7, 'ANTALYA'),
(8, 8, 'ARTVİN'),
(9, 9, 'AYDIN'),
(10, 10, 'BALIKESİR'),
(11, 11, 'BİLECİK'),
(12, 12, 'BİNGÖL'),
(13, 13, 'BİTLİS'),
(14, 14, 'BOLU'),
(15, 15, 'BURDUR'),
(16, 16, 'BURSA'),
(17, 17, 'ÇANAKKALE'),
(18, 18, 'ÇANKIRI'),
(19, 19, 'ÇORUM'),
(20, 20, 'DENİZLİ'),
(21, 21, 'DİYARBAKIR'),
(22, 22, 'EDİRNE'),
(23, 23, 'ELAZIĞ'),
(24, 24, 'ERZİNCAN'),
(25, 25, 'ERZURUM'),
(26, 26, 'ESKİŞEHİR'),
(27, 27, 'GAZİANTEP'),
(28, 28, 'GİRESUN'),
(29, 29, 'GÜMÜŞHANE'),
(30, 30, 'HAKKARİ'),
(31, 31, 'HATAY'),
(32, 32, 'ISPARTA'),
(33, 33, 'MERSİN'),
(34, 34, 'İSTANBUL'),
(35, 35, 'İZMİR'),
(36, 36, 'KARS'),
(37, 37, 'KASTAMONU'),
(38, 38, 'KAYSERİ'),
(39, 39, 'KIRKLARELİ'),
(40, 40, 'KIRŞEHİR'),
(41, 41, 'KOCAELİ'),
(42, 42, 'KONYA'),
(43, 43, 'KÜTAHYA'),
(44, 44, 'MALATYA'),
(45, 45, 'MANİSA'),
(46, 46, 'KAHRAMANMARAŞ'),
(47, 47, 'MARDİN'),
(48, 48, 'MUĞLA'),
(49, 49, 'MUŞ'),
(50, 50, 'NEVŞEHİR'),
(51, 51, 'NİĞDE'),
(52, 52, 'ORDU'),
(53, 53, 'RİZE'),
(54, 54, 'SAKARYA'),
(55, 55, 'SAMSUN'),
(56, 56, 'SİİRT'),
(57, 57, 'SİNOP'),
(58, 58, 'SİVAS'),
(59, 59, 'TEKİRDAĞ'),
(60, 60, 'TOKAT'),
(61, 61, 'TRABZON'),
(62, 62, 'TUNCELİ'),
(63, 63, 'ŞANLIURFA'),
(64, 64, 'UŞAK'),
(65, 65, 'VAN'),
(66, 66, 'YOZGAT'),
(67, 67, 'ZONGULDAK'),
(68, 68, 'AKSARAY'),
(69, 69, 'BAYBURT'),
(70, 70, 'KARAMAN'),
(71, 71, 'KIRIKKALE'),
(72, 72, 'BATMAN'),
(73, 73, 'ŞIRNAK'),
(74, 74, 'BARTIN'),
(75, 75, 'ARDAHAN'),
(76, 76, 'IĞDIR'),
(77, 77, 'YALOVA'),
(78, 78, 'KARABÜK'),
(79, 79, 'KİLİS'),
(80, 80, 'OSMANİYE'),
(81, 81, 'DÜZCE');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_ilyayinevino_tbl`
--

CREATE TABLE `sis_ilyayinevino_tbl` (
  `id` int(11) NOT NULL,
  `ilkodu` int(8) NOT NULL,
  `yil` varchar(10) COLLATE utf8_turkish_ci NOT NULL,
  `bolum` varchar(8) COLLATE utf8_turkish_ci NOT NULL,
  `yayinsnf1` smallint(2) NOT NULL,
  `yayinsnf2` smallint(2) NOT NULL,
  `yayinsnf3` smallint(2) NOT NULL,
  `yayinsnf4` smallint(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_ilyayinevino_tbl`
--

INSERT INTO `sis_ilyayinevino_tbl` (`id`, `ilkodu`, `yil`, `bolum`, `yayinsnf1`, `yayinsnf2`, `yayinsnf3`, `yayinsnf4`) VALUES
(1, 1, '2022-2023', 'S1', 1, 2, 1, 1),
(2, 2, '2022-2023', 'S1', 2, 2, 2, 2),
(3, 3, '2022-2023', 'S1', 2, 2, 2, 2),
(4, 4, '2022-2023', 'S1', 2, 2, 2, 2),
(5, 5, '2022-2023', 'S1', 2, 2, 2, 2),
(6, 6, '2022-2023', 'S1', 1, 2, 1, 1),
(7, 7, '2022-2023', 'S1', 2, 2, 2, 2),
(8, 8, '2022-2023', 'S1', 2, 2, 2, 2),
(9, 9, '2022-2023', 'S1', 2, 2, 2, 2),
(10, 10, '2022-2023', 'S1', 2, 2, 2, 2),
(11, 11, '2022-2023', 'S1', 2, 2, 2, 2),
(12, 12, '2022-2023', 'S1', 2, 2, 2, 2),
(13, 13, '2022-2023', 'S1', 2, 2, 2, 2),
(14, 14, '2022-2023', 'S1', 2, 2, 2, 2),
(15, 15, '2022-2023', 'S1', 2, 2, 2, 2),
(16, 16, '2022-2023', 'S1', 1, 2, 1, 1),
(17, 17, '2022-2023', 'S1', 2, 2, 2, 2),
(18, 18, '2022-2023', 'S1', 2, 2, 2, 2),
(19, 19, '2022-2023', 'S1', 2, 2, 2, 2),
(20, 20, '2022-2023', 'S1', 2, 2, 2, 2),
(21, 21, '2022-2023', 'S1', 2, 2, 2, 2),
(22, 22, '2022-2023', 'S1', 2, 2, 2, 2),
(23, 23, '2022-2023', 'S1', 2, 2, 2, 2),
(24, 24, '2022-2023', 'S1', 2, 2, 2, 2),
(25, 25, '2022-2023', 'S1', 2, 2, 2, 2),
(26, 26, '2022-2023', 'S1', 1, 2, 1, 1),
(27, 27, '2022-2023', 'S1', 2, 2, 2, 2),
(28, 28, '2022-2023', 'S1', 2, 2, 2, 2),
(29, 29, '2022-2023', 'S1', 2, 2, 2, 2),
(30, 30, '2022-2023', 'S1', 2, 2, 2, 2),
(31, 31, '2022-2023', 'S1', 2, 2, 2, 2),
(32, 32, '2022-2023', 'S1', 2, 2, 2, 2),
(33, 33, '2022-2023', 'S1', 2, 2, 2, 2),
(34, 34, '2022-2023', 'S1', 2, 2, 2, 2),
(35, 35, '2022-2023', 'S1', 2, 2, 2, 2),
(36, 36, '2022-2023', 'S1', 2, 2, 2, 2),
(37, 37, '2022-2023', 'S1', 2, 2, 2, 2),
(38, 38, '2022-2023', 'S1', 2, 2, 2, 2),
(39, 39, '2022-2023', 'S1', 2, 2, 2, 2),
(40, 40, '2022-2023', 'S1', 2, 2, 2, 2),
(41, 41, '2022-2023', 'S1', 2, 2, 2, 2),
(42, 42, '2022-2023', 'S1', 1, 2, 1, 1),
(43, 43, '2022-2023', 'S1', 2, 2, 2, 2),
(44, 44, '2022-2023', 'S1', 2, 2, 2, 2),
(45, 45, '2022-2023', 'S1', 2, 2, 2, 2),
(46, 46, '2022-2023', 'S1', 2, 2, 2, 2),
(47, 47, '2022-2023', 'S1', 2, 2, 2, 2),
(48, 48, '2022-2023', 'S1', 2, 2, 2, 2),
(49, 49, '2022-2023', 'S1', 2, 2, 2, 2),
(50, 50, '2022-2023', 'S1', 2, 2, 2, 2),
(51, 51, '2022-2023', 'S1', 2, 2, 2, 2),
(52, 52, '2022-2023', 'S1', 2, 2, 2, 2),
(53, 53, '2022-2023', 'S1', 2, 2, 2, 2),
(54, 54, '2022-2023', 'S1', 2, 2, 2, 2),
(55, 55, '2022-2023', 'S1', 2, 2, 2, 2),
(56, 56, '2022-2023', 'S1', 2, 2, 2, 2),
(57, 57, '2022-2023', 'S1', 2, 2, 2, 2),
(58, 58, '2022-2023', 'S1', 2, 2, 2, 2),
(59, 59, '2022-2023', 'S1', 2, 2, 2, 2),
(60, 60, '2022-2023', 'S1', 2, 2, 2, 2),
(61, 61, '2022-2023', 'S1', 2, 2, 2, 2),
(62, 62, '2022-2023', 'S1', 2, 2, 2, 2),
(63, 63, '2022-2023', 'S1', 2, 2, 2, 2),
(64, 64, '2022-2023', 'S1', 2, 2, 2, 2),
(65, 65, '2022-2023', 'S1', 2, 2, 2, 2),
(66, 66, '2022-2023', 'S1', 2, 2, 2, 2),
(67, 67, '2022-2023', 'S1', 2, 2, 2, 2),
(68, 68, '2022-2023', 'S1', 2, 2, 2, 2),
(69, 69, '2022-2023', 'S1', 2, 2, 2, 2),
(70, 70, '2022-2023', 'S1', 2, 2, 2, 2),
(71, 71, '2022-2023', 'S1', 2, 2, 2, 2),
(72, 72, '2022-2023', 'S1', 2, 2, 2, 2),
(73, 73, '2022-2023', 'S1', 2, 2, 2, 2),
(74, 74, '2022-2023', 'S1', 2, 2, 2, 2),
(75, 75, '2022-2023', 'S1', 2, 2, 2, 2),
(76, 76, '2022-2023', 'S1', 2, 2, 2, 2),
(77, 77, '2022-2023', 'S1', 2, 2, 2, 2),
(78, 78, '2022-2023', 'S1', 2, 2, 2, 2),
(79, 79, '2022-2023', 'S1', 2, 2, 2, 2),
(80, 80, '2022-2023', 'S1', 2, 2, 2, 2),
(81, 81, '2022-2023', 'S1', 2, 2, 2, 2);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_kurtulus_tbl`
--

CREATE TABLE `sis_kurtulus_tbl` (
  `id` int(11) NOT NULL,
  `yeradi` varchar(128) COLLATE utf8_turkish_ci NOT NULL,
  `kutuadi` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `aciklama` varchar(128) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_kurtulus_tbl`
--

INSERT INTO `sis_kurtulus_tbl` (`id`, `yeradi`, `kutuadi`, `aciklama`) VALUES
(1, 'ADANA', 'OCAK', '5 OCAK ADANA\'NIN KURTULUŞU '),
(2, 'AĞRI', 'NISAN', '15 NISAN AĞRI\'NIN KURTULUŞU '),
(3, 'ARTVİN', 'MART', '7 MART ARTVIN\'NIN KURTULUŞU '),
(4, 'AYDIN', 'EYLUL', '7 EYLÜL AYDIN\'IN KURTULUŞU '),
(5, 'BALIKESİR', 'EYLUL', '6 EYLÜL BALIKESIR\'IN KURTULUŞU '),
(6, 'BİLECİK', 'EYLUL', '5 EYLÜL BILECIK\'IN KURTULUŞU '),
(7, 'BURSA', 'EYLUL', '11 EYLÜL BURSA\'NIN KURTULUŞU '),
(8, 'ÇANAKKALE', 'EYLUL', '22 EYLÜL ÇANAKKALE\'NIN KURTULUŞU '),
(9, 'EDİRNE', 'KASIM', '25 KASIM EDIRNE\'NIN KURTULUŞU '),
(10, 'ERZİNCAN', 'SUBAT', '13 ŞUBAT ERZINCAN\'IN KURTULUŞU '),
(11, 'ERZURUM', 'MART', '12 MART ERZURUM\'UN KURTULUŞU '),
(12, 'GAZİANTEP', 'ARALIK', '25 ARALIK GAZIANTEP\'\'IN KURTULUŞU '),
(13, 'GÜMÜŞHANE', 'SUBAT', '15 ŞUBAT GÜMÜŞHANE\'NIN KURTULUŞU '),
(14, 'HAKKARİ', 'NISAN', '12 NISAN HAKKARI\'NIN KURTULUŞU '),
(15, 'İSTANBUL', 'EKIM', '6 EKIM İSTANBUL\'UN KURTULUŞU '),
(16, 'İZMİR', 'EYLUL', '9 EYLÜL İZMIR\'IN KURTULUŞU '),
(17, 'KAHRAMANMARAŞ', 'SUBAT', '12 ŞUBAT KAHRAMANMARAŞ\'IN KURTULUŞU '),
(18, 'KARS', 'NISAN', '25 NISAN KARS\'IN KURTULUŞU '),
(19, 'MANİSA', 'EYLUL', '8 EYLÜL MANISA\'NIN KURTULUŞU '),
(20, 'MARDİN', 'KASIM', '21 KASIM MARDIN\'IN KURTULUŞU '),
(21, 'MUŞ', 'NISAN', '30 NISAN MUŞ\'UN KURTULUŞU '),
(22, 'RİZE', 'MART', '2 MART RIZE\'NIN KURTULUŞU '),
(23, 'ŞANLIURFA', 'NISAN', '11 NISAN ŞANLIURFA\'NIN KURTULUŞU '),
(24, 'TEKİRDAĞ', 'KASIM', '13 KASIM TEKIRDAĞ\'IN KURTULUŞU '),
(25, 'TRABZON', 'SUBAT', '24 ŞUBAT TRABZON\'UN KURTULUŞU '),
(26, 'VAN', 'NISAN', '2 NISAN VAN\'IN KURTULUŞU '),
(27, 'BAYBURT', 'SUBAT', '21 ŞUBAT BAYBURT\'UN KURTULUŞU '),
(28, 'ARDAHAN', 'NISAN', '25 NISAN ARDAHAN\'IN KURTULUŞU '),
(29, 'IĞDIR', 'KASIM', '14 KASIM IĞDIR\'IN KURTULUŞU '),
(30, 'KİLİS', 'ARALIK', '7 ARALIK KILIS\'IN KURTULUŞU '),
(31, 'OSMANİYE', 'OCAK', '7 OCAK OSMANIYE\'NIN KURTULUŞU '),
(32, 'ADANA-Ceyhan', 'OCAK', '6 OCAK CEYHAN\'IN KURTULUŞU'),
(33, 'ADANA-Feke', 'MART', '22 MART FEKE\'NIN KURTULUŞU'),
(34, 'ADANA-Karaisalı', 'NISAN', '1 NISAN KARAISALI\'NIN KURTULUŞU'),
(35, 'ADANA-Pozantı', 'MAYIS', '25 MAYIS POZANTI\'NIN KURTULUŞU'),
(36, 'ADANA-Kozan', 'HAZIRAN', '2 HAZIRAN KOZAN\'IN KURTULUŞU'),
(37, 'ADANA-Saimbeyli', 'EKİM', '18 EKIM SAIMBEYLI\'NIN KURTULUŞU'),
(38, 'ADANA-Düziçi', 'MART', '28 MART DÜZIÇI\'NIN KURTULUŞU'),
(39, 'AĞRI-Doğubeyazıt', 'NISAN', '14 NISAN DOĞU BEYAZIT İLÇESININ KURTULUŞU'),
(40, 'AĞRI-Tutak', 'NISAN', '14 NISAN TUTAK İLÇESININ KURTULUŞU'),
(41, 'AĞRI-Patnos', 'NISAN', '14 NISAN PATNOS İLÇESININ KURTULUŞU'),
(42, 'AĞRI-Diyadin', 'NISAN', '14 NISAN DIYADIN İLÇESININ KURTULUŞU'),
(43, 'AĞRI-Taşlıçay', 'NISAN', '14 NISAN TAŞLIÇAY İLÇESININ KURTULUŞU'),
(44, 'AĞRI-Hamur', 'NISAN', '14 NISAN HAMUR İLÇESININ KURTULUŞU'),
(45, 'AĞRI-Eleşkirt', 'NISAN', '16 NISAN ELEŞKIRT İLÇESININ KURTULUŞU'),
(46, 'ARTVİN-Ardanuç', 'MART', '7 MART ARDANUÇ İLÇESININ KURTULUŞU'),
(47, 'ARTVİN-Borçka', 'MART', '7 MART BORÇKA İLÇESININ KURTULUŞU'),
(48, 'ARTVİN-Şavşat', 'MART', '27 MART ŞAVŞAT İLÇESININ KURTULUŞU'),
(49, 'ARTVİN-Arhavi', 'MART', '12 MART ARHAVI İLÇESININ KURTULUŞU'),
(50, 'ARTVİN-Hopa', 'MART', '14 MART HOPA İLÇESININ KURTULUŞU'),
(51, 'BALIKESİR-Burhaniye', 'EYLUL', '8 EYLÜL BURHANIYE\'NIN KURTULUŞU'),
(52, 'BALIKESİR-Havran', 'EYLUL', '8 EYLÜL HAVRAN\'IN KURTULUŞU'),
(53, 'BALIKESİR-Edremit', 'EYLUL', '9 EYLÜL EDREMIT\'IN KURTULUŞU'),
(54, 'BALIKESİR-Manyas', 'EYLUL', '14 EYLÜL MANYAS\'IN KURTULUŞU'),
(55, 'BALIKESİR-Ayvalık', 'EYLUL', '15 EYLÜL AYVALIK\'IN KURTULUŞU'),
(56, 'BALIKESİR-Bandırma', 'EYLUL', '17 EYLÜL BANDIRMA\'NIN KURTULUŞU'),
(57, 'BALIKESİR-Erdek', 'EYLUL', '18 EYLÜL ERDEK\'IN KURTULUŞU'),
(58, 'BİNGÖL-Karlıova', 'MART', '11 MART KARLIOVA\'NIN KURTULUŞU'),
(59, 'BİNGÖL-Kiği', 'KASIM', '20 KASIM KIĞI\'NIN KURTULUŞU'),
(60, 'BURSA-Orhaneli', 'EYLUL', '9 EYLÜL ORHANELI\'NIN KURTULUŞU'),
(61, 'BURSA-Gemlik', 'EYLUL', '11 EYLÜL GEMLIK\'IN KURTULUŞU'),
(62, 'BURSA-Orhangazi', 'EYLUL', '10 EYLÜL ORHANGAZI\'NIN KURTULUŞU'),
(63, 'BURSA-Mudanya', 'EYLUL', '12 EYLÜL MUDANYA\'NIN KURTULUŞU'),
(64, 'BURSA-Mustafa Kemalpaşa', 'EYLUL', '14 EYLÜL M. KEMALPAŞA\'NIN KURTULUŞU'),
(65, 'BURSA-Karacabey', 'EYLUL', '14 EYLÜL KARACABEY\'IN KURTULUŞU'),
(66, 'BURSA-İznik', 'KASIM', '7 KASIM İZNIK\'IN KURTULUŞU'),
(67, 'ÇANAKKALE-Biga', 'EYLUL', '18 EYLÜL BIGA\'NIN KURTULUŞU'),
(68, 'ÇANAKKALE-Bozcaada', 'EYLUL', '20 EYLÜL BOZCAADA\'NIN KURTULUŞU'),
(69, 'ÇANAKKALE-Gökçeada', 'EKIM', '17 EKIM GÖKÇEADA\'NIN KURTULUŞU'),
(70, 'ÇANAKKALE-Gelibolu', 'KASIM', '26 KASIM GELIBOLU\'NUN KURTULUŞU'),
(71, 'ÇANAKKALE-Çan', 'EYLUL', '23 EYLÜL ÇAN\'IN KURTULUŞU'),
(72, 'EDİRNE-Uzunköprü', 'KASIM', '18 KASIM UZUNKÖPRÜ\'NÜN KURTULUŞU'),
(73, 'EDİRNE-Keşan', 'KASIM', '19 KASIM KEŞAN\'IN KURTULUŞU'),
(74, 'EDİRNE-Meriç', 'KASIM', '19 KASIM MERIÇ\'IN KURTULUŞU'),
(75, 'EDİRNE-İpsala', 'KASIM', '20 KASIM İPSALA\'NIN KURTULUŞU'),
(76, 'EDİRNE-Enez', 'KASIM', '23 KASIM ENEZ\'IN KURTULUŞU'),
(77, 'EDİRNE-Havsa', 'KASIM', '23 KASIM HAVSA\'NIN KURTULUŞU'),
(78, 'EDİRNE-Lalapaşa', 'KASIM', '27 KASIM LALAPAŞA\'NIN KURTULUŞU'),
(79, 'ERZURUM-İspir', 'SUBAT', '25 ŞUBAT İSPIR\'IN KURTULUŞU'),
(80, 'ERZURUM-Aşkale', 'MART', '3 MART AŞKALE\'NIN KURTULUŞU'),
(81, 'ERZURUM-Şenkaya', 'NISAN', '7 NISAN ŞENKAYA\'NIN KURTULUŞU'),
(82, 'ERZURUM-Çat', 'MART', '9 MART ÇAT\'IN KURTULUŞU'),
(83, 'ERZURUM-Ilıca', 'MART', '11 MART ILICA\'NIN KURTULUŞU'),
(84, 'ERZURUM-Pasinler', 'MART', '13 MART PASINLER\'IN KURTULUŞU'),
(85, 'ERZURUM-Hınıs', 'MART', '14 MART HINIS\'IN KURTULUŞU'),
(86, 'ERZURUM-Tekman', 'MART', '15 MART TEKMAN\'IN KURTULUŞU'),
(87, 'ERZURUM-Narman', 'MART', '18 MART NARMAN\'IN KURTULUŞU'),
(88, 'ERZURUM-Karayazı', 'MART', '18 MART KARAYAZI\'NIN KURTULUŞU'),
(89, 'ERZURUM-Tortum', 'MART', '21 MART TORTUM\'UN KURTULUŞU'),
(90, 'ERZURUM-Horosan', 'MART', '16 MART HORASAN\'IN KURTULUŞU'),
(91, 'ERZURUM-Oltu', 'MART', '25 MART OLTU\'NUN KURTULUŞU'),
(92, 'ERZURUM-Olur', 'MART', '28 MART OLUR\'UN KURTULUŞU'),
(93, 'ESKİŞEHİR-Mahmudiye', 'EYLUL', '18 EYLÜL MAHMUDIYE\'NIN KURTULUŞU'),
(94, 'ESKİŞEHİR-Sivrihisar', 'EYLUL', '20 EYLÜL SIVRIHISAR\'IN KURTULUŞU'),
(95, 'GÜMÜŞHANE-Kelkit', 'SUBAT', '17 ŞUBAT KELKIT\'IN KURTULUŞU'),
(96, 'GÜMÜŞHANE-Torul', 'SUBAT', '14 ŞUBAT TORUL\'UN KURTULUŞU '),
(97, 'HATAY-Erzin', 'OCAK', '8 OCAK ERZIN (YEŞILKENT\'IN) KURTULUŞU'),
(98, 'HATAY-Dörtyol', 'OCAK', '9 OCAK DÖRTYOL\'UN KURTULUŞU'),
(99, 'HATAY-Hassa', 'KASIM', '15 KASIM HASSA\'NIN KURTULUŞU'),
(100, 'İZMİR-Bergama', 'EYLUL', '14 EYLÜL BERGAMA\'NIN KURTULUŞU'),
(101, 'İZMİR-Çeşme', 'EYLUL', '16 EYLÜL ÇEŞME\'NIN KURTULUŞU'),
(102, 'İZMİR-Dikili', 'EYLUL', '14 EYLÜL DIKILI\'NIN KURTULUŞU'),
(103, 'İZMİR-Foça', 'EYLUL', '11 EYLÜL FOÇA\'NIN KURTULUŞU'),
(104, 'İZMİR-Karaburun', 'EYLUL', '16 EYLÜL KARABURUN\'UN KURTULUŞU'),
(105, 'İZMİR-Kınık', 'EYLUL', '13 EYLÜL KINIK\'IN KURTULUŞU'),
(106, 'İZMİR-Menemen', 'EYLUL', '9 EYLÜL MENEMEN\'IN KURTULUŞU'),
(107, 'İZMİR-Seferihisar', 'EYLUL', '11 EYLÜL SEFERIHISAR\'IN KURTULUŞU'),
(108, 'İZMİR-Selçuk', 'EYLUL', '8 EYLÜL SELÇUK\'UN KURTULUŞU '),
(109, 'İZMİR-Urla', 'EYLUL', '10 EYLÜL URLA\'NIN KURTULUŞU '),
(110, 'KIRKLARELİ-Vize', 'KASIM', '1 KASIM VIZE\'NIN KURTULUŞU'),
(111, 'KIRKLARELİ-Lüleburgaz', 'KASIM', '8 KASIM LÜLEBURGAZ\'IN KURTULUŞU'),
(112, 'KIRKLARELİ-Babaeski', 'KASIM', '9 KASIM BABAESKI\'NIN KURTULUŞU'),
(113, 'KIRKLARELİ-Pınarhisar', 'KASIM', '9 KASIM PINARHISAR\'IN KURTULUŞU'),
(114, 'KIRKLARELİ-Kuleli', 'KASIM', '9 KASIM KULELI KÖYÜNÜN KURTULUŞU'),
(115, 'KIRKLARELİ-Kofçaz', 'KASIM', '11 KASIM KOFÇAZ\'IN KURTULUŞU'),
(116, 'MANİSA-Kırkağaç', 'EYLUL', '12 EYLÜL KIRKAĞAÇ\'IN KURTULUŞU'),
(117, 'MUŞ-Varto', 'MART', '31 MART VARTO\'NUN KURTULUŞU'),
(118, 'ORDU-Gölköy', 'MAYIS', '20 MAYIS GÖLKÖY\'ÜN KURTULUŞU'),
(119, 'OSMANİYE-Kadirli', 'MART', '7 MART KADIRLI\'NIN KURTULUŞU'),
(120, 'OSMANİYE-Düziçi', 'MART', '28 MART DÜZİÇİ\'NIN KURTULUŞU'),
(121, 'RİZE-Çayeli', 'MART', '9 MART ÇAYELI\'NIN KURTULUŞU'),
(122, 'RİZE-Ardeşen', 'MART', '12 MART ARDEŞEN\'IN KURTULUŞU'),
(123, 'RİZE-Fındıklı', 'MART', '11 MART FINDIKLI\'NIN KURTULUŞU'),
(124, 'SAKARYA-Kaynarca', 'MAYIS', '3 MAYIS KAYNARCA\'NIN KURTULUŞU'),
(125, 'TEKİRDAĞ-Hayrabolu', 'KASIM', '14 KASIM HAYRABOLU\'NUN KURTULUŞU'),
(126, 'TEKİRDAĞ-Çorlu', 'KASIM', '1 KASIM ÇORLU\'NUN KURTULUŞU'),
(127, 'TEKİRDAĞ-Çerkezköy', 'KASIM', '29 KASIM ÇERKEZKÖY\'ÜN KURTULUŞU'),
(128, 'TEKİRDAĞ-Saray', 'KASIM', '1 KASIM SARAY\'IN KURTULUŞU'),
(129, 'TEKİRDAĞ-Muratlı', 'KASIM', '2 KASIM MURATLI\'NIN KURTULUŞU'),
(130, 'TEKİRDAĞ-Malkara', 'KASIM', '14 KASIM MALKARA\'NIN KURTULUŞU'),
(131, 'TEKİRDAĞ-Şarköy', 'KASIM', '17 KASIM ŞARKÖY\'ÜN KURTULUŞU'),
(132, 'TOKAT-Artova', 'HAZIRAN', '1 HAZIRAN ARTOVA İLÇESININ KURTULUŞU'),
(133, 'TRABZON-Vakfıkebir', 'SUBAT', '14 ŞUBAT VAKFIKEBIR\'IN KURTULUŞU'),
(134, 'TRABZON-Tonya', 'SUBAT', '15 ŞUBAT TONYA\'NIN KURTULUŞU'),
(135, 'TRABZON-Akçaabat', 'SUBAT', '17 ŞUBAT AKÇAABAT\'IN KURTULUŞU'),
(136, 'TRABZON-Arsin', 'SUBAT', '24 ŞUBAT ARSIN\'IN KURTULUŞU'),
(137, 'TRABZON-Yomra', 'SUBAT', '24 ŞUBAT YOMRA\'NIN KURTULUŞU'),
(138, 'TRABZON-Maçka', 'SUBAT', '25 ŞUBAT MAÇKA\'NIN KURTULUŞU'),
(139, 'TRABZON-Sürmene', 'SUBAT', '26 ŞUBAT SÜRMENE\'NIN KURTULUŞU'),
(140, 'TRABZON-Çaykara', 'SUBAT', '27 ŞUBAT ÇAYKARA\'NIN KURTULUŞU'),
(141, 'TRABZON-Of', 'SUBAT', '28 ŞUBAT OF\'UN KURTULUŞU'),
(142, 'TUNCELİ-Pülümür', 'ARALIK', '17 ARALIK PÜLÜMÜR\'ÜN KURTULUŞU'),
(143, 'VAN-Erciş', 'NISAN', '1 NISAN ERCIŞ İLÇESININ KURTULUŞU'),
(144, 'VAN-Muradiye', 'NISAN', '2 NISAN MURADIYE İLÇESININ KURTULUŞU'),
(145, 'VAN-Başkale', 'NISAN', '22 NISAN BAŞKALE İLÇESININ KURTULUŞU'),
(146, 'VAN-Özalp', 'NISAN', '3 NISAN ÖZALP İLÇESININ KURTULUŞU'),
(147, 'VAN-Gürpınar', 'NISAN', '1 NISAN GÜRPINAR İLÇESININ KURTULUŞU');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_mudurunvan_tbl`
--

CREATE TABLE `sis_mudurunvan_tbl` (
  `id` int(11) NOT NULL,
  `unvankodu` int(2) NOT NULL,
  `unvan` varchar(64) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_mudurunvan_tbl`
--

INSERT INTO `sis_mudurunvan_tbl` (`id`, `unvankodu`, `unvan`) VALUES
(1, 1, 'Okul Müdürü'),
(2, 2, 'Okul Müdür V.'),
(3, 3, 'Müdür Baş Yardımcısı'),
(4, 4, 'Müdür Yardımcısı'),
(5, 5, 'Müdür Yetkili Öğretmen'),
(6, 6, 'Müdür Yardımcısı'),
(7, 7, 'Milli Eğitim Müdürü');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_nobetyerisablon_tbl`
--

CREATE TABLE `sis_nobetyerisablon_tbl` (
  `id` int(11) NOT NULL,
  `sablon_adi` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `n1` varchar(32) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `n2` varchar(32) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `n3` varchar(32) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `n4` varchar(32) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `n5` varchar(32) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `n6` varchar(32) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `n7` varchar(32) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `n8` varchar(32) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `n9` varchar(32) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `n10` varchar(32) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `n11` varchar(32) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `n12` varchar(32) COLLATE utf8_turkish_ci NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_nobetyerisablon_tbl`
--

INSERT INTO `sis_nobetyerisablon_tbl` (`id`, `sablon_adi`, `n1`, `n2`, `n3`, `n4`, `n5`, `n6`, `n7`, `n8`, `n9`, `n10`, `n11`, `n12`) VALUES
(1, '4_KAT', 'BAHÇE (ÖN)', 'BAHÇE (ARKA)', 'ZEMİN KAT', 'ZEMİN KAT', '1. KAT', '1. KAT', '2. KAT', '2. KAT', '3. KAT', '3. KAT', '4. KAT', '4. KAT'),
(2, '3_KAT', 'BAHÇE (ÖN)', 'BAHÇE (ARKA)', 'ZEMİN KAT', 'ZEMİN KAT', '1. KAT', '1. KAT', '2. KAT', '2. KAT', '3. KAT', '3. KAT', '', ''),
(3, '2_KAT', 'BAHÇE (ÖN)', 'BAHÇE (ARKA)', 'ZEMİN KAT', 'ZEMİN KAT', '1. KAT', '1. KAT', '2. KAT', '2. KAT', '', '', '', ''),
(4, 'Tek Kat', 'Zemin Doğu', 'Zemin Batı', 'Bahçe Ön', 'Bahçe Arka', '', '', '', '', '', '', '', '');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_odemeturu_tbl`
--

CREATE TABLE `sis_odemeturu_tbl` (
  `id` int(11) NOT NULL,
  `odemekodu` int(2) NOT NULL,
  `odemeturu` varchar(36) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_odemeturu_tbl`
--

INSERT INTO `sis_odemeturu_tbl` (`id`, `odemekodu`, `odemeturu`) VALUES
(1, 1, 'Nakit'),
(2, 2, 'Havale'),
(3, 3, 'EFT'),
(4, 4, 'Kredi Kartı'),
(5, 5, 'İndirim'),
(6, 6, 'Diğer');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_serbestetkinlikderssaati_tbl`
--

CREATE TABLE `sis_serbestetkinlikderssaati_tbl` (
  `id` int(11) NOT NULL,
  `yil` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `sinif` int(2) NOT NULL,
  `dersaati` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci COMMENT='Hangi sınıfta kaç saat serbest etkinlik var.';

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_serbestetkinlikler_tbl`
--

CREATE TABLE `sis_serbestetkinlikler_tbl` (
  `id` int(11) NOT NULL,
  `yil` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `dersid` int(8) NOT NULL,
  `dersadi` varchar(64) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_serbestetkinlikler_tbl`
--

INSERT INTO `sis_serbestetkinlikler_tbl` (`id`, `yil`, `dersid`, `dersadi`) VALUES
(1, '2022-2023', 1, 'ATIŞMA'),
(2, '2022-2023', 2, 'BAHÇE ETKİNLİKLERİ'),
(3, '2022-2023', 3, 'BİLİŞİM TEKNOLOJİLERİ'),
(4, '2022-2023', 4, 'BİLMECE'),
(5, '2022-2023', 5, 'BİTKİ VE HAYVAN YETİŞTİRME'),
(6, '2022-2023', 6, 'BULMACA'),
(7, '2022-2023', 7, 'CEVAP VERME'),
(8, '2022-2023', 8, 'DİNLEME'),
(9, '2022-2023', 9, 'DEĞERLER EĞİTİMİ'),
(10, '2022-2023', 10, 'DUYGU VE DÜŞÜNCELERİNİ İFADE ETME'),
(11, '2022-2023', 11, 'FİLM İZLEME'),
(12, '2022-2023', 12, 'FOLKLOR'),
(13, '2022-2023', 13, 'GEZİ_GÖZLEM'),
(14, '2022-2023', 14, 'GRUP TARTIŞMALARI'),
(15, '2022-2023', 15, 'GÜZEL KONUŞMA VE YAZMA'),
(16, '2022-2023', 16, 'İNCELEME'),
(17, '2022-2023', 17, 'KİTAP OKUMA'),
(18, '2022-2023', 18, 'KONSER'),
(19, '2022-2023', 19, 'MONOLOG'),
(20, '2022-2023', 20, 'MÜSAMERE'),
(21, '2022-2023', 21, 'MÜZİKS'),
(22, '2022-2023', 22, 'OYUN'),
(23, '2022-2023', 23, 'SANAT ETKİNLİKLERİ'),
(24, '2022-2023', 24, 'SAYIŞMA'),
(25, '2022-2023', 25, 'SATRANÇ'),
(26, '2022-2023', 26, 'SERGİ DÜZENLEME'),
(27, '2022-2023', 27, 'SORU SORMA'),
(28, '2022-2023', 28, 'SPOR ETKİNLİKLERİ'),
(29, '2022-2023', 29, 'ŞARKI VE TÜRKÜ SÖYLEME');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_siniflar_tbl`
--

CREATE TABLE `sis_siniflar_tbl` (
  `id` int(11) NOT NULL,
  `sinifkodu` int(3) NOT NULL,
  `sinifadi` varchar(16) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci COMMENT='1-2-3..12 sınıflar buradan alınacak.';

--
-- Tablo döküm verisi `sis_siniflar_tbl`
--

INSERT INTO `sis_siniflar_tbl` (`id`, `sinifkodu`, `sinifadi`) VALUES
(1, 1, '03'),
(2, 2, '04'),
(3, 3, '05'),
(4, 4, '06'),
(5, 5, '1'),
(6, 6, '2'),
(7, 7, '3'),
(8, 8, '4'),
(9, 9, '5'),
(10, 10, '6'),
(11, 11, '7'),
(12, 12, '8');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_sosyalkulupler_tbl`
--

CREATE TABLE `sis_sosyalkulupler_tbl` (
  `id` int(11) NOT NULL,
  `yil` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `kulupkodu` int(8) NOT NULL,
  `kulupadi` varchar(128) COLLATE utf8_turkish_ci NOT NULL,
  `bolum` int(4) NOT NULL,
  `grup1` double NOT NULL DEFAULT '0',
  `grup2` double NOT NULL DEFAULT '0',
  `grup3` double NOT NULL DEFAULT '0',
  `grup4` double NOT NULL DEFAULT '0',
  `grup5` double NOT NULL DEFAULT '0',
  `grup6` double NOT NULL DEFAULT '0',
  `grup7` double NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_sosyalkulupler_tbl`
--

INSERT INTO `sis_sosyalkulupler_tbl` (`id`, `yil`, `kulupkodu`, `kulupadi`, `bolum`, `grup1`, `grup2`, `grup3`, `grup4`, `grup5`, `grup6`, `grup7`) VALUES
(1, '2022-2023', 9002, 'Bilim-Fen ve Teknoloji Kulübü', 2, 0, 0, 0, 0, 0, 0, 0),
(2, '2022-2023', 9003, 'Bilinçli  Tüketici Kulübü', 3, 0, 0, 0, 0, 0, 0, 0),
(3, '2022-2023', 9004, 'Çevre Koruma Kulübü', 4, 0, 0, 0, 0, 0, 0, 0),
(4, '2022-2023', 9005, 'Çocuk Hakları Kulübü', 5, 0, 0, 0, 0, 0, 0, 0),
(5, '2022-2023', 9006, 'Demokrasi, İnsan Hakları ve Yurttaşlık Kulübü', 6, 0, 0, 0, 0, 0, 0, 0),
(6, '2022-2023', 9007, 'Denizcilik Kulübü', 7, 0, 0, 0, 0, 0, 0, 0),
(7, '2022-2023', 9008, 'Engellilerle Dayanışma Kulübü', 8, 0, 0, 0, 0, 0, 0, 0),
(8, '2022-2023', 9009, 'Felsefe Kulübü', 9, 0, 0, 0, 0, 0, 0, 0),
(9, '2022-2023', 9010, 'Fotoğrafçılık Kulübü', 10, 0, 0, 0, 0, 0, 0, 0),
(10, '2022-2023', 9011, 'Gezi,Tanıtma ve Turizm Kulübü', 11, 0, 0, 0, 0, 0, 0, 0),
(11, '2022-2023', 9012, 'Halk Oyunları Kulübü', 12, 0, 0, 0, 0, 0, 0, 0),
(12, '2022-2023', 9013, 'Havacılık Kulübü', 13, 0, 0, 0, 0, 0, 0, 0),
(13, '2022-2023', 9014, 'Hayvanları Koruma Kulübü', 14, 0, 0, 0, 0, 0, 0, 0),
(14, '2022-2023', 9015, 'İzcilik Kulübü', 15, 0, 0, 0, 0, 0, 0, 0),
(15, '2022-2023', 9016, 'Kooperatifçilik Kulübü', 16, 0, 0, 0, 0, 0, 0, 0),
(16, '2022-2023', 9017, 'Kültür ve Edebiyat Kulübü', 17, 0, 0, 0, 0, 0, 0, 0),
(17, '2022-2023', 9018, 'Kültür ve Tabiat Varlıklarını Koruma ve Okul Müzesi Kulübü', 18, 0, 0, 0, 0, 0, 0, 0),
(18, '2022-2023', 9019, 'Kütüphanecilik Kulübü', 19, 0, 0, 0, 0, 0, 0, 0),
(19, '2022-2023', 9020, 'Meslek Tanıtma Kulübü', 20, 0, 0, 0, 0, 0, 0, 0),
(20, '2022-2023', 9021, 'Müzik Kulübü', 21, 0, 0, 0, 0, 0, 0, 0),
(21, '2022-2023', 9022, 'Görsel Sanatlar Kulübü', 22, 0, 0, 0, 0, 0, 0, 0),
(22, '2022-2023', 9023, 'Sağlık, Temizlik, Beslenme ve Yeşilay Kulübü', 23, 0, 0, 0, 0, 0, 0, 0),
(23, '2022-2023', 9024, 'Satranç Kulübü', 24, 0, 0, 0, 0, 0, 0, 0),
(24, '2022-2023', 9025, 'Sivil Savunma Kulübü', 25, 0, 0, 0, 0, 0, 0, 0),
(25, '2022-2023', 9026, 'Sosyal Dayanışma ve Yardımlaşma, Çocuk Esirgeme, Kızılay  ve Benzeri  Kulüpler', 26, 0, 0, 0, 0, 0, 0, 0),
(26, '2022-2023', 9027, 'Spor Kulübü', 27, 0, 0, 0, 0, 0, 0, 0),
(27, '2022-2023', 9028, 'Tiyatro Kulübü', 28, 0, 0, 0, 0, 0, 0, 0),
(28, '2022-2023', 9029, 'Trafik Güvenliği ve İlk Yardım Kulübü', 29, 0, 0, 0, 0, 0, 0, 0),
(29, '2022-2023', 9030, 'Yayın ve İletişim Kulübü', 30, 0, 0, 0, 0, 0, 0, 0),
(30, '2022-2023', 9031, 'Yeşili Koruma  Kulübü', 32, 0, 0, 0, 0, 0, 0, 0),
(31, '2022-2023', 9032, 'Matematik Kulübü', 33, 0, 0, 0, 0, 0, 0, 0),
(32, '2022-2023', 9033, 'Kültür, Edebiyat ve Kütüphanecilik Kulübü', 19, 0, 0, 0, 0, 0, 0, 0),
(33, '2022-2023', 9034, 'Drama Kulübü', 31, 0, 0, 0, 0, 0, 0, 0),
(34, '2022-2023', 9035, 'Sosyal Dayanışma ve Yardımlaşma Kulübü', 26, 0, 0, 0, 0, 0, 0, 0),
(35, '2022-2023', 9036, 'Sağlık, Temizlik, Beslenme Kulübü', 23, 0, 0, 0, 0, 0, 0, 0),
(36, '2022-2023', 9037, 'Yeşilay Kulübü', 33, 0, 0, 0, 0, 0, 0, 0),
(37, '2022-2023', 9038, 'Sosyal Dayanışma, Yardımlaşma ve Kızılay Kulübü', 26, 0, 0, 0, 0, 0, 0, 0),
(38, '2022-2023', 9039, 'Demokrasi, İnsan Hakları ve Çocuk Hakları Kulübü', 6, 0, 0, 0, 0, 0, 0, 0),
(39, '2022-2023', 9040, 'Müzik ve Halk Oyunları Kulübü', 21, 0, 0, 0, 0, 0, 0, 0),
(40, '2022-2023', 9041, 'Kızılay Kulübü', 26, 0, 0, 0, 0, 0, 0, 0),
(41, '2022-2023', 9042, 'Çevre ve Yeşili Koruma Kulübü', 32, 0, 0, 0, 0, 0, 0, 0),
(42, '2022-2023', 9036, 'Sağlık, Temizlik ve Kızılay Kulübü', 23, 0, 0, 0, 0, 0, 0, 0),
(43, '2022-2023', 9030, 'Yayın, İletişim ve Kütüphanecilik Kulübü', 30, 0, 0, 0, 0, 0, 0, 0),
(44, '2022-2023', 9003, 'Tüketiciyi Koruma Kulübü', 3, 0, 0, 0, 0, 0, 0, 0),
(45, '2022-2023', 9011, 'Gezi,Tanıtma, Turizm ve Çevre Koruma Kulübü', 11, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_tumdersler_tbl`
--

CREATE TABLE `sis_tumdersler_tbl` (
  `id` int(11) NOT NULL,
  `yil` varchar(16) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `dersadi` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `dersid` int(8) NOT NULL,
  `bolum` int(4) NOT NULL,
  `anadersmi` varchar(6) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `grup1` double NOT NULL,
  `grup2` double NOT NULL,
  `grup3` double NOT NULL,
  `grup4` double NOT NULL,
  `grup5` double NOT NULL,
  `grup6` double NOT NULL,
  `grup7` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_tumdersler_tbl`
--

INSERT INTO `sis_tumdersler_tbl` (`id`, `yil`, `dersadi`, `dersid`, `bolum`, `anadersmi`, `grup1`, `grup2`, `grup3`, `grup4`, `grup5`, `grup6`, `grup7`) VALUES
(1, '2022-2023', '1-SERBEST ETKİNLİKLER', 1201, 10, '', 0, 0, 0, 0, 0, 0, 0),
(2, '2022-2023', '1-BAHÇE ETKİNLİKLERİ', 1202, 11, '', 0, 0, 0, 0, 0, 0, 0),
(3, '2022-2023', '1-BİLİŞİM TEKNOLOJİLERİ VE YAZILIM', 1203, 12, '', 0, 0, 0, 0, 0, 0, 0),
(4, '2022-2023', '1-BİLMECE', 1204, 13, '', 0, 0, 0, 0, 0, 0, 0),
(5, '2022-2023', '1-BİTKİ VE HAYVAN YETİŞTİRME', 1205, 14, '', 0, 0, 0, 0, 0, 0, 0),
(6, '2022-2023', '1-BULMACA', 1206, 15, '', 0, 0, 0, 0, 0, 0, 0),
(7, '2022-2023', '1-CEVAP VERME', 1207, 16, '', 0, 0, 0, 0, 0, 0, 0),
(8, '2022-2023', '1-DİNLEME', 1208, 17, '', 0, 0, 0, 0, 0, 0, 0),
(9, '2022-2023', '1-DEĞERLER EĞİTİMİ', 1209, 18, '', 0, 0, 0, 0, 0, 0, 0),
(10, '2022-2023', '1-DUYGU VE DÜŞÜNCELERİNİ İFADE ETME', 1210, 19, '', 0, 0, 0, 0, 0, 0, 0),
(11, '2022-2023', '1-FİLM İZLEME', 1211, 20, '', 0, 0, 0, 0, 0, 0, 0),
(12, '2022-2023', '1-FOLKLOR', 1212, 21, '', 0, 0, 0, 0, 0, 0, 0),
(13, '2022-2023', '1-GEZİ_GÖZLEM', 1213, 22, '', 0, 0, 0, 0, 0, 0, 0),
(14, '2022-2023', '1-Görsel Sanatlar', 1061, 8, '', 9, 0, 0, 0, 0, 0, 0),
(15, '2022-2023', '1-GRUP TARTIŞMALARI', 1214, 23, '', 0, 0, 0, 0, 0, 0, 0),
(16, '2022-2023', '1-GÜZEL KONUŞMA VE YAZMA', 1215, 24, '', 0, 0, 0, 0, 0, 0, 0),
(17, '2022-2023', '1-Hayat Bilgisi-ARDIÇ', 1022, 2, '', 9, 0, 0, 0, 0, 0, 0),
(18, '2022-2023', '1-İNCELEME', 1216, 25, '', 0, 0, 0, 0, 0, 0, 0),
(19, '2022-2023', '1-KİTAP OKUMA', 1217, 26, '', 0, 0, 0, 0, 0, 0, 0),
(20, '2022-2023', '1-KONSER', 1218, 27, '', 0, 0, 0, 0, 0, 0, 0),
(21, '2022-2023', '1-Matematik-MEB', 1041, 5, 'X', 9, 0, 0, 0, 0, 0, 0),
(22, '2022-2023', '1-Matematik-MHG', 1042, 6, 'X', 9, 0, 0, 0, 0, 0, 0),
(23, '2022-2023', '1-MONOLOG', 1219, 28, '', 0, 0, 0, 0, 0, 0, 0),
(24, '2022-2023', '1-MÜSAMERE', 1220, 29, '', 0, 0, 0, 0, 0, 0, 0),
(25, '2022-2023', '1-Müzik', 1071, 9, 'X', 9, 0, 0, 0, 0, 0, 0),
(26, '2022-2023', '1-MÜZİKS', 1221, 30, '', 0, 0, 0, 0, 0, 0, 0),
(27, '2022-2023', '1-OYUN', 1222, 31, '', 0, 0, 0, 0, 0, 0, 0),
(28, '2022-2023', '1-Oyun ve Fiziki Etkinlikler', 1051, 7, 'X', 9, 0, 0, 0, 0, 0, 0),
(29, '2022-2023', '1-SANAT ETKİNLİKLERİ', 1223, 32, '', 0, 0, 0, 0, 0, 0, 0),
(30, '2022-2023', '1-SATRANÇ', 1224, 33, '', 0, 0, 0, 0, 0, 0, 0),
(31, '2022-2023', '1-SAYIŞMA', 1225, 34, '', 0, 0, 0, 0, 0, 0, 0),
(32, '2022-2023', '1-SERGİ DÜZENLEME', 1226, 35, '', 0, 0, 0, 0, 0, 0, 0),
(33, '2022-2023', '1-SORU SORMA', 1227, 36, '', 0, 0, 0, 0, 0, 0, 0),
(34, '2022-2023', '1-SPOR ETKİNLİKLERİ', 1228, 37, '', 0, 0, 0, 0, 0, 0, 0),
(35, '2022-2023', '1-ŞARKI VE TÜRKÜ SÖYLEME', 1229, 38, '', 0, 0, 0, 0, 0, 0, 0),
(36, '2022-2023', '1-Türkçe-MEB', 1031, 3, 'X', 9, 49, 50, 66, 71, 60, 60),
(37, '2022-2023', '1-Türkçe-CEM', 1032, 4, 'X', 9, 49, 50, 66, 71, 60, 60),
(38, '2022-2023', '2-SERBEST ETKİNLİKLER', 2201, 11, '', 0, 0, 0, 0, 0, 0, 0),
(39, '2022-2023', '2-BAHÇE ETKİNLİKLERİ', 2202, 12, '', 0, 0, 0, 0, 0, 0, 0),
(40, '2022-2023', '2-BİLİŞİM TEKNOLOJİLERİ VE YAZILIM', 2203, 13, '', 0, 0, 0, 0, 0, 0, 0),
(41, '2022-2023', '2-BİLMECE', 2204, 14, '', 0, 0, 0, 0, 0, 0, 0),
(42, '2022-2023', '2-BİTKİ VE HAYVAN YETİŞTİRME', 2205, 15, '', 0, 0, 0, 0, 0, 0, 0),
(43, '2022-2023', '2-BULMACA', 2206, 16, '', 0, 0, 0, 0, 0, 0, 0),
(44, '2022-2023', '2-CEVAP VERME', 2207, 17, '', 0, 0, 0, 0, 0, 0, 0),
(45, '2022-2023', '2-DİNLEME', 2208, 18, '', 0, 0, 0, 0, 0, 0, 0),
(46, '2022-2023', '2-DEĞERLER EĞİTİMİ', 2209, 19, '', 0, 0, 0, 0, 0, 0, 0),
(47, '2022-2023', '2-DUYGU VE DÜŞÜNCELERİNİ İFADE ETME', 2210, 20, '', 0, 0, 0, 0, 0, 0, 0),
(48, '2022-2023', '2-FİLM İZLEME', 2211, 21, '', 0, 0, 0, 0, 0, 0, 0),
(49, '2022-2023', '2-FOLKLOR', 2212, 22, '', 0, 0, 0, 0, 0, 0, 0),
(50, '2022-2023', '2-GEZİ_GÖZLEM', 2213, 23, '', 0, 0, 0, 0, 0, 0, 0),
(51, '2022-2023', '2-Görsel Sanatlar', 2061, 8, 'X', 9, 0, 0, 0, 0, 0, 0),
(52, '2022-2023', '2-GRUP TARTIŞMALARI', 2214, 24, '', 0, 0, 0, 0, 0, 0, 0),
(53, '2022-2023', '2-GÜZEL KONUŞMA VE YAZMA', 2215, 25, '', 0, 0, 0, 0, 0, 0, 0),
(54, '2022-2023', '2-Hayat Bilgisi-MEB', 2021, 2, 'X', 9, 0, 0, 0, 0, 0, 0),
(55, '2022-2023', '2-Hayat Bilgisi-BEŞGEN', 2022, 3, 'X', 9, 0, 0, 0, 0, 0, 0),
(56, '2022-2023', '2-İNCELEME', 2216, 26, '', 0, 0, 0, 0, 0, 0, 0),
(57, '2022-2023', '2-KİTAP OKUMA', 2217, 27, '', 0, 0, 0, 0, 0, 0, 0),
(58, '2022-2023', '2-KONSER', 2218, 28, '', 0, 0, 0, 0, 0, 0, 0),
(59, '2022-2023', '2-Matematik-MEB', 2041, 5, 'X', 9, 0, 0, 0, 0, 0, 0),
(60, '2022-2023', '2-Matematik-TEKNO ARTI', 2042, 6, 'X', 9, 0, 0, 0, 0, 0, 0),
(61, '2022-2023', '2-MONOLOG', 2219, 29, '', 0, 0, 0, 0, 0, 0, 0),
(62, '2022-2023', '2-MÜSAMERE', 2220, 30, '', 0, 0, 0, 0, 0, 0, 0),
(63, '2022-2023', '2-Müzik', 2071, 9, 'X', 9, 0, 0, 0, 0, 0, 0),
(64, '2022-2023', '2-MÜZİKS', 2221, 31, '', 0, 0, 0, 0, 0, 0, 0),
(65, '2022-2023', '2-OYUN', 2222, 32, '', 0, 0, 0, 0, 0, 0, 0),
(66, '2022-2023', '2-Oyun ve Fiziki Etkinlikler', 2051, 7, 'X', 9, 0, 0, 0, 0, 0, 0),
(67, '2022-2023', '2-SANAT ETKİNLİKLERİ', 2223, 33, '', 0, 0, 0, 0, 0, 0, 0),
(68, '2022-2023', '2-SATRANÇ', 2224, 34, '', 0, 0, 0, 0, 0, 0, 0),
(69, '2022-2023', '2-SAYIŞMA', 2225, 35, '', 0, 0, 0, 0, 0, 0, 0),
(70, '2022-2023', '2-SERGİ DÜZENLEME', 2226, 36, '', 0, 0, 0, 0, 0, 0, 0),
(71, '2022-2023', '2-SORU SORMA', 2227, 37, '', 0, 0, 0, 0, 0, 0, 0),
(72, '2022-2023', '2-SPOR ETKİNLİKLERİ', 2228, 38, '', 0, 0, 0, 0, 0, 0, 0),
(73, '2022-2023', '2-ŞARKI VE TÜRKÜ SÖYLEME', 2229, 39, '', 0, 0, 0, 0, 0, 0, 0),
(74, '2022-2023', '2-Yabancı Dil-ARAPÇA', 2230, 40, '', 0, 0, 0, 0, 0, 0, 0),
(75, '2022-2023', '2-Türkçe-KOZA', 2032, 4, 'X', 9, 49, 50, 66, 71, 60, 60),
(76, '2022-2023', '2-Yabancı Dil', 2081, 10, 'X', 40, 18, 22, 26, 30, 20, 20),
(77, '2022-2023', '3-SERBEST ETKİNLİKLER', 3201, 14, '', 0, 0, 0, 0, 0, 0, 0),
(78, '2022-2023', '3-BAHÇE ETKİNLİKLERİ', 3202, 15, '', 0, 0, 0, 0, 0, 0, 0),
(79, '2022-2023', '3-BİLİŞİM TEKNOLOJİLERİ VE YAZILIM', 3203, 16, '', 0, 0, 0, 0, 0, 0, 0),
(80, '2022-2023', '3-BİLMECE', 3204, 17, '', 0, 0, 0, 0, 0, 0, 0),
(81, '2022-2023', '3-BİTKİ VE HAYVAN YETİŞTİRME', 3205, 18, '', 0, 0, 0, 0, 0, 0, 0),
(82, '2022-2023', '3-BULMACA', 3206, 19, '', 0, 0, 0, 0, 0, 0, 0),
(83, '2022-2023', '3-CEVAP VERME', 3207, 20, '', 0, 0, 0, 0, 0, 0, 0),
(84, '2022-2023', '3-DİNLEME', 3208, 21, '', 0, 0, 0, 0, 0, 0, 0),
(85, '2022-2023', '3-DEĞERLER EĞİTİMİ', 3209, 22, '', 0, 0, 0, 0, 0, 0, 0),
(86, '2022-2023', '3-DUYGU VE DÜŞÜNCELERİNİ İFADE ETME', 3210, 23, '', 0, 0, 0, 0, 0, 0, 0),
(87, '2022-2023', '3-Fen Bilimleri-MEB', 3011, 2, 'X', 9, 0, 0, 0, 0, 0, 0),
(88, '2022-2023', '3-Fen Bilimleri-TUNA', 3012, 3, 'X', 9, 0, 0, 0, 0, 0, 0),
(89, '2022-2023', '3-FİLM İZLEME', 3211, 24, '', 0, 0, 0, 0, 0, 0, 0),
(90, '2022-2023', '3-FOLKLOR', 3212, 25, '', 0, 0, 0, 0, 0, 0, 0),
(91, '2022-2023', '3-GEZİ_GÖZLEM', 3213, 26, '', 0, 0, 0, 0, 0, 0, 0),
(92, '2022-2023', '3-Görsel Sanatlar', 3061, 11, 'X', 9, 0, 0, 0, 0, 0, 0),
(93, '2022-2023', '3-GRUP TARTIŞMALARI', 3214, 27, '', 0, 0, 0, 0, 0, 0, 0),
(94, '2022-2023', '3-GÜZEL KONUŞMA VE YAZMA', 3215, 28, '', 0, 0, 0, 0, 0, 0, 0),
(95, '2022-2023', '3-Hayat Bilgisi-MEB', 3021, 4, 'X', 9, 0, 0, 0, 0, 0, 0),
(96, '2022-2023', '3-Hayat Bilgisi-EVREN', 3022, 5, 'X', 9, 0, 0, 0, 0, 0, 0),
(97, '2022-2023', '3-İNCELEME', 3216, 29, '', 0, 0, 0, 0, 0, 0, 0),
(98, '2022-2023', '3-KİTAP OKUMA', 3217, 30, '', 0, 0, 0, 0, 0, 0, 0),
(99, '2022-2023', '3-KONSER', 3218, 31, '', 0, 0, 0, 0, 0, 0, 0),
(100, '2022-2023', '3-Matematik-MEB', 3041, 8, 'X', 9, 0, 0, 0, 0, 0, 0),
(101, '2022-2023', '3-Matematik-ADA', 3042, 9, 'X', 9, 0, 0, 0, 0, 0, 0),
(102, '2022-2023', '3-MONOLOG', 3219, 32, '', 0, 0, 0, 0, 0, 0, 0),
(103, '2022-2023', '3-MÜSAMERE', 3220, 33, '', 0, 0, 0, 0, 0, 0, 0),
(104, '2022-2023', '3-Müzik', 3071, 12, 'X', 9, 0, 0, 0, 0, 0, 0),
(105, '2022-2023', '3-MÜZİKS', 3221, 34, '', 0, 0, 0, 0, 0, 0, 0),
(106, '2022-2023', '3-OYUN', 3222, 35, '', 0, 0, 0, 0, 0, 0, 0),
(107, '2022-2023', '3-Oyun ve Fiziki Etkinlikler', 3051, 10, 'X', 9, 0, 0, 0, 0, 0, 0),
(108, '2022-2023', '3-SANAT ETKİNLİKLERİ', 3223, 36, '', 0, 0, 0, 0, 0, 0, 0),
(109, '2022-2023', '3-SATRANÇ', 3224, 37, '', 0, 0, 0, 0, 0, 0, 0),
(110, '2022-2023', '3-SAYIŞMA', 3225, 38, '', 0, 0, 0, 0, 0, 0, 0),
(111, '2022-2023', '3-SERGİ DÜZENLEME', 3226, 39, '', 0, 0, 0, 0, 0, 0, 0),
(112, '2022-2023', '3-SORU SORMA', 3227, 40, '', 0, 0, 0, 0, 0, 0, 0),
(113, '2022-2023', '3-SPOR ETKİNLİKLERİ', 3228, 41, '', 0, 0, 0, 0, 0, 0, 0),
(114, '2022-2023', '3-ŞARKI VE TÜRKÜ SÖYLEME', 3229, 42, '', 0, 0, 0, 0, 0, 0, 0),
(115, '2022-2023', '3-Türkçe-MEB', 3031, 6, 'X', 9, 49, 50, 72, 77, 66, 66),
(116, '2022-2023', '3-Türkçe-SONUÇ', 3032, 7, 'X', 9, 49, 50, 72, 77, 66, 66),
(117, '2022-2023', '3-Yabancı Dil', 3081, 13, 'X', 40, 18, 22, 26, 30, 20, 20),
(118, '2022-2023', '4-Din Kültürü ve Ahlak Bilgisi', 4091, 15, '', 40, 18, 22, 26, 30, 20, 20),
(119, '2022-2023', '4-Fen Bilimleri-MEB', 4011, 2, 'X', 8, 0, 0, 0, 0, 0, 0),
(120, '2022-2023', '4-Fen Bilimleri-SDRİPEKYOLU', 4012, 3, 'X', 8, 0, 0, 0, 0, 0, 0),
(121, '2022-2023', '4-Görsel Sanatlar', 4061, 10, 'X', 8, 0, 0, 0, 0, 0, 0),
(122, '2022-2023', '4-İnsan Hakları, Demokrasi ve Yurttaşlık', 4111, 13, 'X', 8, 0, 0, 0, 0, 0, 0),
(123, '2022-2023', '4-Matematik-MEB', 4041, 7, 'X', 8, 0, 0, 0, 0, 0, 0),
(124, '2022-2023', '4-Matematik-ATA', 4042, 8, 'X', 8, 0, 0, 0, 0, 0, 0),
(125, '2022-2023', '4-Müzik', 4071, 11, 'X', 8, 0, 0, 0, 0, 0, 0),
(126, '2022-2023', '4-Oyun ve Fiziki Etkinlikler', 4051, 9, 'X', 8, 0, 0, 0, 0, 0, 0),
(127, '2022-2023', '4-Sosyal Bilgiler-TUNA', 4022, 4, 'X', 8, 0, 0, 0, 0, 0, 0),
(128, '2022-2023', '4-Trafik Güvenliği', 4101, 12, 'X', 8, 0, 0, 0, 0, 0, 0),
(129, '2022-2023', '4-Türkçe-MEB', 4031, 5, 'X', 8, 49, 50, 84, 89, 78, 78),
(130, '2022-2023', '4-Türkçe-KOZA', 4032, 6, 'X', 8, 49, 50, 84, 89, 78, 78),
(131, '2022-2023', '4-Yabancı Dil', 4081, 14, 'X', 40, 18, 22, 26, 30, 20, 20),
(132, '2022-2023', '5-Beden Eğitimi ve Spor', 5051, 7, 'X', 20, 9, 10, 13, 15, 10, 10),
(133, '2022-2023', '5-BİLİM UYGULAMALARI', 5201, 13, '', 20, 9, 10, 13, 15, 10, 10),
(134, '2022-2023', '5-Bilişim Teknolojileri ve Yazılım', 5101, 12, 'X', 20, 9, 10, 13, 15, 10, 10),
(135, '2022-2023', '5-Din Kültürü ve Ahlak Bilgisi', 5091, 11, 'X', 20, 9, 10, 13, 15, 10, 10),
(136, '2022-2023', '5-DRAMA', 5204, 14, '', 20, 9, 10, 13, 15, 10, 10),
(137, '2022-2023', '5-Fen Bilimleri', 5011, 2, 'X', 20, 9, 10, 13, 15, 10, 10),
(138, '2022-2023', '5-Görsel Sanatlar', 5061, 8, 'X', 20, 9, 10, 13, 15, 10, 10),
(139, '2022-2023', '5-GÖRSEL SANATLAR-2', 5206, 15, '', 20, 9, 10, 13, 15, 10, 10),
(140, '2022-2023', '5-HALK KÜLTÜRÜ', 5207, 16, '', 20, 9, 10, 13, 15, 10, 10),
(141, '2022-2023', '5-KURAN-I KERİM', 5211, 17, '', 20, 9, 10, 13, 15, 10, 10),
(142, '2022-2023', '5-MATEMATİK UYGULAMALARI', 5212, 18, '', 20, 9, 10, 13, 15, 10, 10),
(143, '2022-2023', '5-Matematik', 5041, 6, 'X', 20, 9, 10, 13, 15, 10, 10),
(144, '2022-2023', '5-Müzik', 5071, 9, 'X', 20, 9, 10, 13, 15, 10, 10),
(145, '2022-2023', '5-MÜZİK-2', 5214, 19, '', 20, 9, 10, 13, 15, 10, 10),
(146, '2022-2023', '5-OKUMA BECERİLERİ', 5215, 20, '', 20, 9, 10, 13, 15, 10, 10),
(147, '2022-2023', '5-PEYGAMBERİMİZİN HAYATI', 5209, 21, '', 20, 9, 10, 13, 15, 10, 10),
(148, '2022-2023', '5-Sosyal Bilgiler', 5021, 3, 'X', 20, 9, 10, 13, 15, 10, 10),
(149, '2022-2023', '5-SPOR VE FİZİKİ ETKİNLİKLER', 5216, 22, '', 20, 9, 10, 13, 15, 10, 10),
(150, '2022-2023', '5-ŞEHRİMİZ', 5222, 23, '', 20, 9, 10, 13, 15, 10, 10),
(151, '2022-2023', '5-TEMEL DİNİ BİLGİLER', 5217, 24, '', 20, 9, 10, 13, 15, 10, 10),
(152, '2022-2023', '5-Türkçe-MEB', 5031, 4, 'X', 20, 9, 10, 13, 15, 10, 10),
(153, '2022-2023', '5-Türkçe-ANITTEPE', 5032, 5, 'X', 20, 9, 10, 13, 15, 10, 10),
(154, '2022-2023', '5-Yabancı Dil', 5081, 10, 'X', 20, 9, 10, 13, 15, 10, 10),
(155, '2022-2023', '5-YABANCI DİL-2', 5218, 25, '', 20, 9, 10, 13, 15, 10, 10),
(156, '2022-2023', '5-YAŞAYAN DİLLER VE LEHÇELER', 5219, 26, '', 20, 9, 10, 13, 15, 10, 10),
(157, '2022-2023', '5-YAZARLIK VE YAZMA BECERİLERİ', 5220, 27, '', 20, 9, 10, 13, 15, 10, 10),
(158, '2022-2023', '5-ZEKA OYUNLARI', 5221, 28, '', 20, 9, 10, 13, 15, 10, 10),
(159, '2022-2023', '6-Beden Eğitimi ve Spor', 6051, 7, 'X', 20, 9, 10, 13, 15, 10, 10),
(160, '2022-2023', '6-BİLİM UYGULAMALARI', 6201, 13, '', 20, 9, 10, 13, 15, 10, 10),
(161, '2022-2023', '6-Bilişim Teknolojileri ve Yazılım', 6101, 12, 'X', 20, 9, 10, 13, 15, 10, 10),
(162, '2022-2023', '6-Din Kültürü ve Ahlak Bilgisi', 6091, 11, 'X', 20, 9, 10, 13, 15, 10, 10),
(163, '2022-2023', '6-DRAMA', 6204, 14, '', 20, 9, 10, 13, 15, 10, 10),
(164, '2022-2023', '6-Fen Bilimleri', 6011, 2, 'X', 20, 9, 10, 13, 15, 10, 10),
(165, '2022-2023', '6-Görsel Sanatlar', 6061, 8, 'X', 20, 9, 10, 13, 15, 10, 10),
(166, '2022-2023', '6-GÖRSEL SANATLAR-2', 6206, 15, '', 20, 9, 10, 13, 15, 10, 10),
(167, '2022-2023', '6-HALK KÜLTÜRÜ', 6207, 16, '', 20, 9, 10, 13, 15, 10, 10),
(168, '2022-2023', '6-HUKUK VE ADALET', 6208, 17, '', 20, 9, 10, 13, 15, 10, 10),
(169, '2022-2023', '6-KURAN-I KERİM', 6211, 18, '', 20, 9, 10, 13, 15, 10, 10),
(170, '2022-2023', '6-MATEMATİK UYGULAMALARI', 6212, 19, '', 20, 9, 10, 13, 15, 10, 10),
(171, '2022-2023', '6-Matematik', 6041, 6, 'X', 20, 9, 10, 13, 15, 10, 10),
(172, '2022-2023', '6-Müzik', 6071, 9, 'X', 20, 9, 10, 13, 15, 10, 10),
(173, '2022-2023', '6-MÜZİK-2', 6214, 20, '', 20, 9, 10, 13, 15, 10, 10),
(174, '2022-2023', '6-OKUMA BECERİLERİ', 6215, 21, '', 20, 9, 10, 13, 15, 10, 10),
(175, '2022-2023', '6-PEYGAMBERİMİZİN HAYATI', 6209, 22, '', 20, 9, 10, 13, 15, 10, 10),
(176, '2022-2023', '6-Sosyal Bilgiler', 6021, 3, 'X', 20, 9, 10, 13, 15, 10, 10),
(177, '2022-2023', '6-SPOR VE FİZİKİ ETKİNLİKLER', 6216, 23, '', 20, 9, 10, 13, 15, 10, 10),
(178, '2022-2023', '6-ŞEHRİMİZ', 6222, 24, '', 20, 9, 10, 13, 15, 10, 10),
(179, '2022-2023', '6-TEMEL DİNİ BİLGİLER', 6217, 25, '', 20, 9, 10, 13, 15, 10, 10),
(180, '2022-2023', '6-Türkçe-MEB', 6031, 4, 'X', 20, 9, 10, 13, 15, 10, 10),
(181, '2022-2023', '6-Türkçe-EKOYAY', 6032, 5, 'X', 20, 9, 10, 13, 15, 10, 10),
(182, '2022-2023', '6-Yabancı Dil', 6081, 10, 'X', 20, 9, 10, 13, 15, 10, 10),
(183, '2022-2023', '6-YABANCI DİL-2', 6218, 26, '', 20, 9, 10, 13, 15, 10, 10),
(184, '2022-2023', '6-YAŞAYAN DİLLER VE LEHÇELER', 6219, 27, '', 20, 9, 10, 13, 15, 10, 10),
(185, '2022-2023', '6-YAZARLIK VE YAZMA BECERİLERİ', 6220, 28, '', 20, 9, 10, 13, 15, 10, 10),
(186, '2022-2023', '6-ZEKA OYUNLARI', 6221, 29, '', 20, 9, 10, 13, 15, 10, 10),
(187, '2022-2023', '7-Beden Eğitimi ve Spor', 7051, 9, 'X', 20, 9, 10, 13, 15, 10, 10),
(188, '2022-2023', '7-BİLİM UYGULAMALARI', 7201, 14, '', 20, 9, 10, 13, 15, 10, 10),
(189, '2022-2023', '7-BİLİŞİM TEKNOLOJİLERİ VE YAZILIM', 7202, 15, '', 20, 9, 10, 13, 15, 10, 10),
(190, '2022-2023', '7-ÇEVRE VE BİLİM', 7203, 16, '', 20, 9, 10, 13, 15, 10, 10),
(191, '2022-2023', '7-Din Kültürü ve Ahlak Bilgisi', 7091, 12, 'X', 20, 9, 10, 13, 15, 10, 10),
(192, '2022-2023', '7-DÜŞÜNME EĞİTİMİ', 7205, 17, '', 20, 9, 10, 13, 15, 10, 10),
(193, '2022-2023', '7-Fen Bilimleri', 7011, 2, 'X', 20, 9, 10, 13, 15, 10, 10),
(194, '2022-2023', '7-Görsel Sanatlar', 7061, 8, 'X', 20, 9, 10, 13, 15, 10, 10),
(195, '2022-2023', '7-GÖRSEL SANATLAR-2', 7206, 18, '', 20, 9, 10, 13, 15, 10, 10),
(196, '2022-2023', '7-HALK KÜLTÜRÜ', 7207, 19, '', 20, 9, 10, 13, 15, 10, 10),
(197, '2022-2023', '7-HUKUK VE ADALET', 7208, 20, '', 20, 9, 10, 13, 15, 10, 10),
(198, '2022-2023', '7-İLETİŞİM VE SUNUM BECERİLERİ', 7210, 21, '', 20, 9, 10, 13, 15, 10, 10),
(199, '2022-2023', '7-KURAN-I KERİM', 7211, 22, '', 20, 9, 10, 13, 15, 10, 10),
(200, '2022-2023', '7-MATEMATİK UYGULAMALARI', 7212, 23, '', 20, 9, 10, 13, 15, 10, 10),
(201, '2022-2023', '7-Matematik', 7041, 7, 'X', 20, 9, 10, 13, 15, 10, 10),
(202, '2022-2023', '7-MEDYA OKURYAZARLIĞI', 7213, 24, '', 20, 9, 10, 13, 15, 10, 10),
(203, '2022-2023', '7-Müzik', 7071, 10, 'X', 20, 9, 10, 13, 15, 10, 10),
(204, '2022-2023', '7-MÜZİK-2', 7214, 25, '', 20, 9, 10, 13, 15, 10, 10),
(205, '2022-2023', '7-PEYGAMBERİMİZİN HAYATI', 7209, 26, '', 20, 9, 10, 13, 15, 10, 10),
(206, '2022-2023', '7-Sosyal Bilgiler', 7021, 3, 'X', 20, 9, 10, 13, 15, 10, 10),
(207, '2022-2023', '7-SPOR VE FİZİKİ ETKİNLİKLER', 7216, 27, '', 20, 9, 10, 13, 15, 10, 10),
(208, '2022-2023', '7-ŞEHRİMİZ', 7222, 28, '', 20, 9, 10, 13, 15, 10, 10),
(209, '2022-2023', '7-Teknoloji ve Tasarım', 7111, 13, 'X', 20, 9, 10, 13, 15, 10, 10),
(210, '2022-2023', '7-TEMEL DİNİ BİLGİLER', 7217, 29, '', 20, 9, 10, 13, 15, 10, 10),
(211, '2022-2023', '7-Türkçe-MEB-1', 7031, 4, 'X', 20, 9, 10, 13, 15, 10, 10),
(212, '2022-2023', '7-Türkçe-MEB-2', 7033, 5, 'X', 20, 9, 10, 13, 15, 10, 10),
(213, '2022-2023', '7-Türkçe-ÖZGÜN', 7032, 6, 'X', 20, 9, 10, 13, 15, 10, 10),
(214, '2022-2023', '7-Yabancı Dil', 7081, 11, 'X', 20, 9, 10, 13, 15, 10, 10),
(215, '2022-2023', '7-YABANCI DİL-2', 7218, 30, '', 20, 9, 10, 13, 15, 10, 10),
(216, '2022-2023', '7-YAŞAYAN DİLLER VE LEHÇELER', 7219, 31, '', 20, 9, 10, 13, 15, 10, 10),
(217, '2022-2023', '7-YAZARLIK VE YAZMA BECERİLERİ', 7220, 32, '', 20, 9, 10, 13, 15, 10, 10),
(218, '2022-2023', '7-ZEKA OYUNLARI', 7221, 33, '', 20, 9, 10, 13, 15, 10, 10),
(219, '2022-2023', '8-Beden Eğitimi ve Spor', 8051, 6, 'X', 20, 9, 10, 13, 15, 10, 10),
(220, '2022-2023', '8-BİLİM UYGULAMALARI', 8201, 13, '', 20, 9, 10, 13, 15, 10, 10),
(221, '2022-2023', '8-BİLİŞİM TEKNOLOJİLERİ VE YAZILIM', 8202, 14, '', 20, 9, 10, 13, 15, 10, 10),
(222, '2022-2023', '8-ÇEVRE VE BİLİM', 8203, 15, '', 20, 9, 10, 13, 15, 10, 10),
(223, '2022-2023', '8-Din Kültürü ve Ahlak Bilgisi', 8091, 10, 'X', 20, 9, 10, 13, 15, 10, 10),
(224, '2022-2023', '8-DÜŞÜNME EĞİTİMİ', 8205, 16, '', 20, 9, 10, 13, 15, 10, 10),
(225, '2022-2023', '8-Fen Bilimleri', 8011, 2, 'X', 20, 9, 10, 13, 15, 10, 10),
(226, '2022-2023', '8-Görsel Sanatlar', 8061, 7, 'X', 20, 9, 10, 13, 15, 10, 10),
(227, '2022-2023', '8-GÖRSEL SANATLAR-2', 8206, 17, '', 20, 9, 10, 13, 15, 10, 10),
(228, '2022-2023', '8-HALK KÜLTÜRÜ', 8207, 18, '', 20, 9, 10, 13, 15, 10, 10),
(229, '2022-2023', '8-HUKUK VE ADALET', 8208, 19, '', 20, 9, 10, 13, 15, 10, 10),
(230, '2022-2023', '8-İLETİŞİM VE SUNUM BECERİLERİ', 8210, 20, '', 20, 9, 10, 13, 15, 10, 10),
(231, '2022-2023', '8-KURAN-I KERİM', 8211, 21, '', 20, 9, 10, 13, 15, 10, 10),
(232, '2022-2023', '8-MATEMATİK UYGULAMALARI', 8212, 22, '', 20, 9, 10, 13, 15, 10, 10),
(233, '2022-2023', '8-Matematik', 8041, 5, 'X', 20, 9, 10, 13, 15, 10, 10),
(234, '2022-2023', '8-MEDYA OKURYAZARLIĞI', 8213, 23, '', 20, 9, 10, 13, 15, 10, 10),
(235, '2022-2023', '8-Müzik', 8071, 8, 'X', 20, 9, 10, 13, 15, 10, 10),
(236, '2022-2023', '8-MÜZİK-2', 8214, 24, '', 20, 9, 10, 13, 15, 10, 10),
(237, '2022-2023', '8-PEYGAMBERİMİZİN HAYATI', 8209, 25, '', 20, 9, 10, 13, 15, 10, 10),
(238, '2022-2023', '8-Rehberlik ve Sosyal Etkinlikler', 8121, 12, 'X', 20, 9, 10, 13, 15, 10, 10),
(239, '2022-2023', '8-ORTAK TÜRK TARİHİ', 8223, 26, '', 20, 9, 10, 13, 15, 10, 10),
(240, '2022-2023', '8-SPOR VE FİZİKİ ETKİNLİKLER', 8216, 27, '', 20, 9, 10, 13, 15, 10, 10),
(241, '2022-2023', '8-ŞEHRİMİZ', 8222, 28, '', 20, 9, 10, 13, 15, 10, 10),
(242, '2022-2023', '8-TC İnkılap Tarihi ve Atatürkçülük', 8021, 3, 'X', 20, 9, 10, 13, 15, 10, 10),
(243, '2022-2023', '8-Teknoloji ve Tasarım', 8111, 11, 'X', 20, 9, 10, 13, 15, 10, 10),
(244, '2022-2023', '8-TEMEL DİNİ BİLGİLER', 8217, 29, '', 20, 9, 10, 13, 15, 10, 10),
(245, '2022-2023', '8-Türkçe-MEB', 8031, 4, 'X', 20, 9, 10, 13, 15, 10, 10),
(246, '2022-2023', '8-Yabancı Dil', 8081, 9, 'X', 20, 9, 10, 13, 15, 10, 10),
(247, '2022-2023', '8-YABANCI DİL-2', 8218, 30, '', 20, 9, 10, 13, 15, 10, 10),
(248, '2022-2023', '8-YAŞAYAN DİLLER VE LEHÇELER', 8219, 31, '', 20, 9, 10, 13, 15, 10, 10),
(249, '2022-2023', '8-YAZARLIK VE YAZMA BECERİLERİ', 8220, 32, '', 20, 9, 10, 13, 15, 10, 10),
(250, '2022-2023', '8-ZEKA OYUNLARI', 8221, 33, '', 20, 9, 10, 13, 15, 10, 10);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_varsayilanlar_tbl`
--

CREATE TABLE `sis_varsayilanlar_tbl` (
  `id` int(11) NOT NULL,
  `yilkodu` int(3) NOT NULL,
  `bayikodu` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `defter_kayit_yolu_pdf` varchar(1024) COLLATE utf8_turkish_ci NOT NULL,
  `plan_kayit_yolu_pdf` varchar(1024) COLLATE utf8_turkish_ci NOT NULL,
  `yillikplanyolu` varchar(1024) COLLATE utf8_turkish_ci NOT NULL,
  `gunlukplanyolu` varchar(1024) COLLATE utf8_turkish_ci NOT NULL,
  `plankapakyolu` varchar(1024) COLLATE utf8_turkish_ci NOT NULL,
  `defteryolu` varchar(1024) COLLATE utf8_turkish_ci NOT NULL,
  `defterkapakyolu` varchar(1024) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sis_varsayilanlar_tbl`
--

INSERT INTO `sis_varsayilanlar_tbl` (`id`, `yilkodu`, `bayikodu`, `defter_kayit_yolu_pdf`, `plan_kayit_yolu_pdf`, `yillikplanyolu`, `gunlukplanyolu`, `plankapakyolu`, `defteryolu`, `defterkapakyolu`) VALUES
(1, 2, '388', 'C:\\Materyall\\pdfler\\defterler', 'C:\\Materyall\\pdfler\\planlar', 'C:\\Materyall\\SistemDosyaları\\Planlar\\Yillikplanlar', 'C:\\Materyall\\SistemDosyaları\\Planlar\\Günlükplanlar', 'C:\\Materyall\\SistemDosyaları\\Planlar\\Plankapakları', 'C:\\Materyall\\SistemDosyaları\\Defterler\\Defterdosyaları', 'C:\\Materyall\\SistemDosyaları\\Defterler\\DefterKapakDosyaları');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sis_yillar_tbl`
--

CREATE TABLE `sis_yillar_tbl` (
  `id` int(11) NOT NULL,
  `yilkodu` int(2) NOT NULL,
  `yiladi` varchar(10) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci COMMENT='Eğitim öğretim yıllarını buradan alacağız.';

--
-- Tablo döküm verisi `sis_yillar_tbl`
--

INSERT INTO `sis_yillar_tbl` (`id`, `yilkodu`, `yiladi`) VALUES
(1, 1, '2021-2022'),
(2, 2, '2022-2023'),
(3, 3, '2023-2024'),
(4, 4, '2024-2025');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tlp_defterler_tbl`
--

CREATE TABLE `tlp_defterler_tbl` (
  `id` int(11) NOT NULL,
  `oid` int(11) NOT NULL,
  `defterkodu` int(8) NOT NULL,
  `fiyat` double NOT NULL,
  `taleptarihi` datetime NOT NULL,
  `basimtarihi` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tlp_defterler_tbl`
--

INSERT INTO `tlp_defterler_tbl` (`id`, `oid`, `defterkodu`, `fiyat`, `taleptarihi`, `basimtarihi`) VALUES
(1, 1, 161, 7, '2022-05-04 21:58:59', NULL),
(2, 2, 151, 7, '2022-05-04 21:58:59', NULL),
(3, 3, 151, 7, '2022-05-04 21:59:00', NULL),
(4, 4, 161, 7, '2022-05-04 21:59:00', NULL),
(5, 5, 161, 7, '2022-05-04 21:59:00', NULL),
(6, 6, 161, 7, '2022-05-04 21:59:00', NULL),
(7, 7, 161, 7, '2022-05-04 21:59:00', NULL),
(8, 8, 161, 7, '2022-05-04 21:59:01', NULL),
(9, 9, 161, 7, '2022-05-04 21:59:01', NULL),
(10, 10, 161, 7, '2022-05-04 21:59:01', NULL),
(11, 11, 161, 7, '2022-05-04 21:59:01', NULL),
(12, 12, 161, 7, '2022-05-04 21:59:01', NULL),
(13, 13, 161, 7, '2022-05-04 21:59:01', NULL),
(14, 14, 161, 7, '2022-05-04 21:59:02', NULL),
(15, 15, 161, 7, '2022-05-04 21:59:02', NULL),
(16, 16, 161, 7, '2022-05-04 21:59:02', NULL),
(17, 17, 161, 7, '2022-05-04 21:59:02', NULL),
(18, 18, 161, 7, '2022-05-04 21:59:02', NULL),
(19, 19, 161, 7, '2022-05-04 21:59:02', NULL),
(20, 20, 161, 7, '2022-05-04 21:59:03', NULL),
(21, 21, 161, 7, '2022-05-04 21:59:03', NULL),
(22, 22, 161, 7, '2022-05-04 21:59:03', NULL),
(23, 23, 161, 7, '2022-05-04 21:59:03', NULL),
(24, 24, 161, 7, '2022-05-04 21:59:03', NULL),
(25, 25, 161, 7, '2022-05-04 21:59:04', NULL),
(26, 26, 161, 7, '2022-05-04 21:59:04', NULL),
(27, 27, 161, 7, '2022-05-04 21:59:04', NULL),
(28, 28, 161, 7, '2022-05-04 21:59:04', NULL),
(29, 29, 161, 7, '2022-05-04 21:59:04', NULL),
(30, 30, 171, 8, '2022-05-04 21:59:04', NULL),
(31, 31, 171, 8, '2022-05-04 21:59:05', NULL),
(32, 32, 171, 8, '2022-05-04 21:59:05', NULL),
(33, 33, 171, 8, '2022-05-04 21:59:05', NULL),
(34, 34, 171, 8, '2022-05-04 21:59:05', NULL),
(35, 35, 171, 8, '2022-05-04 21:59:05', NULL),
(36, 36, 171, 8, '2022-05-04 21:59:05', NULL),
(37, 37, 171, 8, '2022-05-04 21:59:06', NULL),
(38, 38, 171, 8, '2022-05-04 21:59:06', NULL),
(39, 39, 171, 8, '2022-05-04 21:59:06', NULL),
(40, 40, 171, 8, '2022-05-04 21:59:06', NULL),
(41, 41, 171, 8, '2022-05-04 21:59:06', NULL),
(42, 42, 171, 8, '2022-05-04 21:59:06', NULL),
(43, 43, 171, 8, '2022-05-04 21:59:07', NULL),
(44, 44, 171, 8, '2022-05-04 21:59:07', NULL),
(45, 45, 171, 8, '2022-05-04 21:59:07', NULL),
(46, 46, 171, 8, '2022-05-04 21:59:07', NULL),
(47, 47, 171, 8, '2022-05-04 21:59:07', NULL),
(48, 48, 171, 8, '2022-05-04 21:59:07', NULL),
(49, 49, 171, 8, '2022-05-04 21:59:08', NULL),
(50, 50, 171, 8, '2022-05-04 21:59:08', NULL),
(51, 51, 171, 8, '2022-05-04 21:59:08', NULL),
(52, 52, 171, 8, '2022-05-04 21:59:08', NULL),
(53, 53, 171, 8, '2022-05-04 21:59:08', NULL),
(54, 54, 171, 8, '2022-05-04 21:59:09', NULL),
(55, 55, 171, 8, '2022-05-04 21:59:09', NULL),
(56, 56, 171, 8, '2022-05-04 21:59:09', NULL),
(57, 57, 171, 8, '2022-05-04 21:59:09', NULL),
(58, 58, 171, 8, '2022-05-04 21:59:09', NULL),
(59, 59, 171, 8, '2022-05-04 21:59:09', NULL),
(60, 60, 171, 8, '2022-05-04 21:59:10', NULL),
(61, 61, 171, 8, '2022-05-04 21:59:10', NULL),
(62, 62, 161, 7, '2022-05-04 21:59:10', NULL),
(63, 63, 161, 7, '2022-05-04 21:59:10', NULL),
(64, 64, 161, 7, '2022-05-04 21:59:10', NULL),
(65, 65, 161, 7, '2022-05-04 21:59:10', NULL),
(66, 66, 161, 7, '2022-05-04 21:59:11', NULL),
(67, 67, 161, 7, '2022-05-04 21:59:11', NULL),
(68, 68, 161, 7, '2022-05-04 21:59:11', NULL),
(69, 69, 161, 7, '2022-05-04 21:59:11', NULL),
(70, 70, 161, 7, '2022-05-04 21:59:11', NULL),
(71, 71, 161, 7, '2022-05-04 21:59:12', NULL),
(72, 72, 161, 7, '2022-05-04 21:59:12', NULL),
(73, 73, 161, 7, '2022-05-04 21:59:12', NULL),
(74, 74, 161, 7, '2022-05-04 21:59:12', NULL),
(75, 75, 161, 7, '2022-05-04 21:59:12', NULL),
(76, 76, 161, 7, '2022-05-04 21:59:13', NULL),
(77, 77, 161, 7, '2022-05-04 21:59:13', NULL),
(78, 78, 161, 7, '2022-05-04 21:59:13', NULL),
(79, 79, 161, 7, '2022-05-04 21:59:13', NULL),
(80, 80, 161, 7, '2022-05-04 21:59:13', NULL),
(81, 81, 161, 7, '2022-05-04 21:59:13', NULL),
(82, 82, 161, 7, '2022-05-04 21:59:14', NULL),
(83, 83, 161, 7, '2022-05-04 21:59:14', NULL),
(84, 84, 161, 7, '2022-05-04 21:59:14', NULL),
(85, 85, 161, 7, '2022-05-04 21:59:14', NULL),
(86, 86, 161, 7, '2022-05-04 21:59:14', NULL),
(87, 87, 161, 7, '2022-05-04 21:59:15', NULL),
(88, 88, 161, 7, '2022-05-04 21:59:15', NULL),
(89, 89, 151, 7, '2022-05-04 21:59:15', NULL),
(90, 90, 151, 7, '2022-05-04 21:59:15', NULL),
(91, 91, 151, 7, '2022-05-04 21:59:15', NULL),
(92, 92, 151, 7, '2022-05-04 21:59:16', NULL),
(93, 93, 161, 7, '2022-05-04 21:59:16', NULL),
(94, 94, 161, 7, '2022-05-04 21:59:16', NULL),
(95, 95, 161, 7, '2022-05-04 21:59:16', NULL),
(96, 96, 161, 7, '2022-05-04 21:59:16', NULL),
(97, 97, 161, 7, '2022-05-04 21:59:16', NULL),
(98, 98, 161, 7, '2022-05-04 21:59:17', NULL),
(99, 99, 161, 7, '2022-05-04 21:59:17', NULL),
(100, 100, 161, 7, '2022-05-04 21:59:17', NULL),
(101, 101, 161, 7, '2022-05-04 21:59:17', NULL),
(102, 102, 161, 7, '2022-05-04 21:59:17', NULL),
(103, 103, 161, 7, '2022-05-04 21:59:18', NULL),
(104, 104, 161, 7, '2022-05-04 21:59:18', NULL),
(105, 105, 161, 7, '2022-05-04 21:59:18', NULL),
(106, 106, 161, 7, '2022-05-04 21:59:18', NULL),
(107, 107, 161, 7, '2022-05-04 21:59:18', NULL),
(108, 108, 161, 7, '2022-05-04 21:59:19', NULL),
(109, 109, 161, 7, '2022-05-04 21:59:19', NULL),
(110, 110, 161, 7, '2022-05-04 21:59:19', NULL),
(111, 111, 161, 7, '2022-05-04 21:59:19', NULL),
(112, 112, 161, 7, '2022-05-04 21:59:19', NULL),
(113, 113, 161, 7, '2022-05-04 21:59:20', NULL),
(114, 114, 161, 7, '2022-05-04 21:59:20', NULL),
(115, 115, 171, 8, '2022-05-04 21:59:20', NULL),
(116, 116, 171, 8, '2022-05-04 21:59:20', NULL),
(117, 117, 171, 8, '2022-05-04 21:59:20', NULL),
(118, 118, 171, 8, '2022-05-04 21:59:20', NULL),
(119, 119, 171, 8, '2022-05-04 21:59:21', NULL),
(120, 120, 171, 8, '2022-05-04 21:59:21', NULL),
(121, 121, 171, 8, '2022-05-04 21:59:21', NULL),
(122, 122, 171, 8, '2022-05-04 21:59:21', NULL),
(123, 123, 171, 8, '2022-05-04 21:59:21', NULL),
(124, 124, 171, 8, '2022-05-04 21:59:21', NULL),
(125, 125, 171, 8, '2022-05-04 21:59:22', NULL),
(126, 126, 171, 8, '2022-05-04 21:59:22', NULL),
(127, 127, 171, 8, '2022-05-04 21:59:22', NULL),
(128, 128, 171, 8, '2022-05-04 21:59:22', NULL),
(129, 129, 171, 8, '2022-05-04 21:59:22', NULL),
(130, 130, 171, 8, '2022-05-04 21:59:23', NULL),
(131, 131, 171, 8, '2022-05-04 21:59:23', NULL),
(132, 132, 171, 8, '2022-05-04 21:59:23', NULL),
(133, 133, 171, 8, '2022-05-04 21:59:23', NULL),
(134, 134, 171, 8, '2022-05-04 21:59:23', NULL),
(135, 135, 171, 8, '2022-05-04 21:59:23', NULL),
(136, 136, 171, 8, '2022-05-04 21:59:24', NULL),
(137, 137, 171, 8, '2022-05-04 21:59:24', NULL),
(138, 138, 171, 8, '2022-05-04 21:59:24', NULL),
(139, 139, 171, 8, '2022-05-04 21:59:24', NULL),
(140, 140, 171, 8, '2022-05-04 21:59:24', NULL),
(141, 141, 171, 8, '2022-05-04 21:59:24', NULL),
(142, 142, 171, 8, '2022-05-04 21:59:25', NULL),
(143, 143, 171, 8, '2022-05-04 21:59:25', NULL),
(144, 144, 171, 8, '2022-05-04 21:59:25', NULL),
(145, 145, 171, 8, '2022-05-04 21:59:25', NULL),
(146, 146, 171, 8, '2022-05-04 21:59:25', NULL),
(147, 147, 171, 8, '2022-05-04 21:59:26', NULL),
(148, 148, 171, 8, '2022-05-04 21:59:26', NULL),
(149, 149, 171, 8, '2022-05-04 21:59:26', NULL),
(150, 150, 171, 8, '2022-05-04 21:59:26', NULL),
(151, 151, 171, 8, '2022-05-04 21:59:26', NULL),
(152, 152, 171, 8, '2022-05-04 21:59:26', NULL),
(153, 153, 171, 8, '2022-05-04 21:59:27', NULL),
(154, 154, 171, 8, '2022-05-04 21:59:27', NULL),
(155, 155, 171, 8, '2022-05-04 21:59:27', NULL),
(156, 156, 171, 8, '2022-05-04 21:59:27', NULL),
(157, 157, 171, 8, '2022-05-04 21:59:27', NULL),
(158, 158, 171, 8, '2022-05-04 21:59:27', NULL),
(159, 159, 171, 8, '2022-05-04 21:59:28', NULL),
(160, 160, 171, 8, '2022-05-04 21:59:28', NULL),
(161, 161, 171, 8, '2022-05-04 21:59:28', NULL),
(162, 162, 171, 8, '2022-05-04 21:59:28', NULL),
(163, 163, 171, 8, '2022-05-04 21:59:28', NULL),
(164, 164, 171, 8, '2022-05-04 21:59:28', NULL),
(165, 165, 171, 8, '2022-05-04 21:59:29', NULL),
(166, 166, 171, 8, '2022-05-04 21:59:29', NULL),
(167, 167, 171, 8, '2022-05-04 21:59:29', NULL),
(168, 168, 171, 8, '2022-05-04 21:59:29', NULL),
(169, 169, 171, 8, '2022-05-04 21:59:29', NULL),
(170, 170, 171, 8, '2022-05-04 21:59:30', NULL),
(171, 171, 171, 8, '2022-05-04 21:59:30', NULL),
(172, 172, 171, 8, '2022-05-04 21:59:30', NULL),
(173, 173, 171, 8, '2022-05-04 21:59:30', NULL),
(174, 174, 171, 8, '2022-05-04 21:59:30', NULL),
(175, 175, 171, 8, '2022-05-04 21:59:30', NULL),
(176, 176, 151, 7, '2022-05-04 21:59:31', NULL),
(177, 177, 151, 7, '2022-05-04 21:59:31', NULL),
(178, 178, 151, 7, '2022-05-04 21:59:31', NULL),
(179, 179, 151, 7, '2022-05-04 21:59:31', NULL),
(180, 180, 161, 7, '2022-05-04 21:59:31', NULL),
(181, 181, 161, 7, '2022-05-04 21:59:32', NULL),
(182, 182, 161, 7, '2022-05-04 21:59:32', NULL),
(183, 183, 161, 7, '2022-05-04 21:59:32', NULL),
(184, 184, 161, 7, '2022-05-04 21:59:32', NULL),
(185, 185, 161, 7, '2022-05-04 21:59:32', NULL),
(186, 186, 161, 7, '2022-05-04 21:59:33', NULL),
(187, 187, 161, 7, '2022-05-04 21:59:33', NULL),
(188, 188, 161, 7, '2022-05-04 21:59:33', NULL),
(189, 189, 161, 7, '2022-05-04 21:59:33', NULL),
(190, 190, 161, 7, '2022-05-04 21:59:33', NULL),
(191, 191, 161, 7, '2022-05-04 21:59:33', NULL),
(192, 192, 161, 7, '2022-05-04 21:59:34', NULL),
(193, 193, 161, 7, '2022-05-04 21:59:34', NULL),
(194, 194, 161, 7, '2022-05-04 21:59:34', NULL),
(195, 195, 161, 7, '2022-05-04 21:59:34', NULL),
(196, 196, 161, 7, '2022-05-04 21:59:34', NULL),
(197, 197, 161, 7, '2022-05-04 21:59:35', NULL),
(198, 198, 161, 7, '2022-05-04 21:59:35', NULL),
(199, 199, 161, 7, '2022-05-04 21:59:35', NULL),
(200, 200, 161, 7, '2022-05-04 21:59:35', NULL),
(201, 201, 161, 7, '2022-05-04 21:59:35', NULL),
(202, 202, 161, 7, '2022-05-04 21:59:36', NULL),
(203, 203, 161, 7, '2022-05-04 21:59:36', NULL),
(204, 204, 161, 7, '2022-05-04 21:59:36', NULL),
(205, 205, 161, 7, '2022-05-04 21:59:36', NULL),
(206, 206, 151, 7, '2022-05-04 21:59:36', NULL),
(207, 207, 151, 7, '2022-05-04 21:59:37', NULL),
(208, 208, 151, 7, '2022-05-04 21:59:37', NULL),
(209, 209, 161, 7, '2022-05-04 21:59:37', NULL),
(210, 210, 161, 7, '2022-05-04 21:59:37', NULL),
(211, 211, 161, 7, '2022-05-04 21:59:37', NULL),
(212, 212, 161, 7, '2022-05-04 21:59:38', NULL),
(213, 213, 161, 7, '2022-05-04 21:59:38', NULL),
(214, 214, 161, 7, '2022-05-04 21:59:38', NULL),
(215, 215, 161, 7, '2022-05-04 21:59:38', NULL),
(216, 216, 161, 7, '2022-05-04 21:59:38', NULL),
(217, 217, 161, 7, '2022-05-04 21:59:39', NULL),
(218, 218, 161, 7, '2022-05-04 21:59:39', NULL),
(219, 219, 161, 7, '2022-05-04 21:59:39', NULL),
(220, 220, 161, 7, '2022-05-04 21:59:39', NULL),
(221, 221, 161, 7, '2022-05-04 21:59:39', NULL),
(222, 222, 161, 7, '2022-05-04 21:59:40', NULL),
(223, 223, 161, 7, '2022-05-04 21:59:40', NULL),
(224, 224, 161, 7, '2022-05-04 21:59:40', NULL),
(225, 225, 161, 7, '2022-05-04 21:59:40', NULL),
(226, 226, 161, 7, '2022-05-04 21:59:40', NULL),
(227, 227, 161, 7, '2022-05-04 21:59:41', NULL),
(228, 228, 161, 7, '2022-05-04 21:59:41', NULL),
(229, 229, 181, 8, '2022-05-04 21:59:41', NULL),
(230, 230, 181, 8, '2022-05-04 21:59:41', NULL),
(231, 231, 181, 8, '2022-05-04 21:59:41', NULL),
(232, 232, 181, 8, '2022-05-04 21:59:41', NULL),
(233, 233, 181, 8, '2022-05-04 21:59:42', NULL),
(234, 234, 181, 8, '2022-05-04 21:59:42', NULL),
(235, 235, 181, 8, '2022-05-04 21:59:42', NULL),
(236, 236, 181, 8, '2022-05-04 21:59:42', NULL),
(237, 237, 181, 8, '2022-05-04 21:59:42', NULL),
(238, 238, 181, 8, '2022-05-04 21:59:43', NULL),
(239, 239, 181, 8, '2022-05-04 21:59:43', NULL),
(240, 240, 181, 8, '2022-05-04 21:59:43', NULL),
(241, 241, 181, 8, '2022-05-04 21:59:43', NULL),
(242, 242, 181, 8, '2022-05-04 21:59:43', NULL),
(243, 243, 181, 8, '2022-05-04 21:59:43', NULL),
(244, 244, 181, 8, '2022-05-04 21:59:44', NULL),
(245, 245, 181, 8, '2022-05-04 21:59:44', NULL),
(246, 246, 181, 8, '2022-05-04 21:59:44', NULL),
(247, 247, 181, 8, '2022-05-04 21:59:44', NULL),
(248, 248, 181, 8, '2022-05-04 21:59:44', NULL),
(249, 249, 181, 8, '2022-05-04 21:59:44', NULL),
(250, 250, 181, 8, '2022-05-04 21:59:45', NULL),
(251, 251, 181, 8, '2022-05-04 21:59:45', NULL),
(252, 252, 181, 8, '2022-05-04 21:59:45', NULL),
(253, 253, 171, 8, '2022-05-04 21:59:45', NULL),
(254, 254, 171, 8, '2022-05-04 21:59:45', NULL),
(255, 255, 171, 8, '2022-05-04 21:59:46', NULL),
(256, 256, 171, 8, '2022-05-04 21:59:46', NULL),
(257, 257, 151, 7, '2022-05-04 21:59:46', NULL),
(258, 258, 161, 7, '2022-05-04 21:59:46', NULL),
(259, 259, 161, 7, '2022-05-04 21:59:46', NULL),
(260, 260, 161, 7, '2022-05-04 21:59:47', NULL),
(261, 261, 161, 7, '2022-05-04 21:59:47', NULL),
(262, 262, 182, 8, '2022-05-04 21:59:47', NULL),
(263, 263, 182, 8, '2022-05-04 21:59:47', NULL),
(264, 264, 182, 8, '2022-05-04 21:59:47', NULL),
(265, 265, 182, 8, '2022-05-04 21:59:47', NULL),
(266, 266, 182, 8, '2022-05-04 21:59:48', NULL),
(267, 267, 182, 8, '2022-05-04 21:59:48', NULL),
(268, 268, 182, 8, '2022-05-04 21:59:48', NULL),
(269, 269, 182, 8, '2022-05-04 21:59:48', NULL),
(270, 270, 182, 8, '2022-05-04 21:59:48', NULL),
(271, 271, 182, 8, '2022-05-04 21:59:49', NULL),
(272, 272, 182, 8, '2022-05-04 21:59:49', NULL),
(273, 273, 182, 8, '2022-05-04 21:59:49', NULL),
(274, 274, 182, 8, '2022-05-04 21:59:49', NULL),
(275, 275, 182, 8, '2022-05-04 21:59:49', NULL),
(276, 276, 182, 8, '2022-05-04 21:59:49', NULL),
(277, 277, 182, 8, '2022-05-04 21:59:50', NULL),
(278, 278, 182, 8, '2022-05-04 21:59:50', NULL),
(279, 279, 182, 8, '2022-05-04 21:59:50', NULL),
(280, 280, 182, 8, '2022-05-04 21:59:50', NULL),
(281, 281, 182, 8, '2022-05-04 21:59:50', NULL),
(282, 282, 182, 8, '2022-05-04 21:59:50', NULL),
(283, 283, 182, 8, '2022-05-04 21:59:51', NULL),
(284, 284, 182, 8, '2022-05-04 21:59:51', NULL),
(285, 285, 182, 8, '2022-05-04 21:59:51', NULL),
(286, 286, 182, 8, '2022-05-04 21:59:51', NULL),
(287, 287, 182, 8, '2022-05-04 21:59:51', NULL),
(288, 288, 182, 8, '2022-05-04 21:59:52', NULL),
(289, 289, 182, 8, '2022-05-04 21:59:52', NULL),
(290, 290, 182, 8, '2022-05-04 21:59:52', NULL),
(291, 291, 182, 8, '2022-05-04 21:59:52', NULL),
(292, 292, 151, 7, '2022-05-04 21:59:52', NULL),
(293, 293, 151, 7, '2022-05-04 21:59:52', NULL),
(294, 294, 181, 8, '2022-05-04 21:59:53', NULL),
(295, 295, 181, 8, '2022-05-04 21:59:53', NULL),
(296, 296, 181, 8, '2022-05-04 21:59:53', NULL),
(297, 297, 181, 8, '2022-05-04 21:59:53', NULL),
(298, 298, 181, 8, '2022-05-04 21:59:53', NULL),
(299, 299, 181, 8, '2022-05-04 21:59:54', NULL),
(300, 300, 181, 8, '2022-05-04 21:59:54', NULL),
(301, 301, 181, 8, '2022-05-04 21:59:54', NULL),
(302, 302, 171, 8, '2022-05-04 21:59:54', NULL),
(303, 303, 171, 8, '2022-05-04 21:59:54', NULL),
(304, 304, 171, 8, '2022-05-04 21:59:54', NULL),
(305, 305, 171, 8, '2022-05-04 21:59:55', NULL),
(306, 306, 171, 8, '2022-05-04 21:59:55', NULL),
(307, 307, 171, 8, '2022-05-04 21:59:55', NULL),
(308, 308, 171, 8, '2022-05-04 21:59:55', NULL),
(309, 309, 171, 8, '2022-05-04 21:59:55', NULL),
(310, 310, 171, 8, '2022-05-04 21:59:55', NULL),
(311, 311, 171, 8, '2022-05-04 21:59:56', NULL),
(312, 312, 171, 8, '2022-05-04 21:59:56', NULL),
(313, 313, 171, 8, '2022-05-04 21:59:56', NULL),
(314, 314, 171, 8, '2022-05-04 21:59:56', NULL),
(315, 315, 171, 8, '2022-05-04 21:59:56', NULL),
(316, 316, 171, 8, '2022-05-04 21:59:57', NULL),
(317, 317, 171, 8, '2022-05-04 21:59:57', NULL),
(318, 318, 171, 8, '2022-05-04 21:59:57', NULL),
(319, 319, 171, 8, '2022-05-04 21:59:57', NULL),
(320, 320, 151, 7, '2022-05-04 21:59:57', NULL),
(321, 321, 151, 7, '2022-05-04 21:59:58', NULL),
(322, 322, 151, 7, '2022-05-04 21:59:58', NULL),
(323, 323, 151, 7, '2022-05-04 21:59:58', NULL),
(324, 324, 151, 7, '2022-05-04 21:59:58', NULL),
(325, 325, 151, 7, '2022-05-04 21:59:59', NULL),
(326, 326, 151, 7, '2022-05-04 21:59:59', NULL),
(327, 327, 151, 7, '2022-05-04 21:59:59', NULL),
(328, 328, 151, 7, '2022-05-04 21:59:59', NULL),
(329, 329, 151, 7, '2022-05-04 21:59:59', NULL),
(330, 330, 151, 7, '2022-05-04 22:00:00', NULL),
(331, 331, 151, 7, '2022-05-04 22:00:00', NULL),
(332, 332, 151, 7, '2022-05-04 22:00:00', NULL),
(333, 333, 151, 7, '2022-05-04 22:00:00', NULL),
(334, 334, 151, 7, '2022-05-04 22:00:01', NULL),
(335, 335, 151, 7, '2022-05-04 22:00:01', NULL),
(336, 336, 151, 7, '2022-05-04 22:00:01', NULL),
(337, 337, 161, 7, '2022-05-04 22:00:01', NULL),
(338, 338, 161, 7, '2022-05-04 22:00:02', NULL),
(339, 339, 161, 7, '2022-05-04 22:00:02', NULL),
(340, 340, 161, 7, '2022-05-04 22:00:02', NULL),
(341, 341, 171, 8, '2022-05-04 22:00:02', NULL),
(342, 342, 171, 8, '2022-05-04 22:00:03', NULL),
(343, 343, 171, 8, '2022-05-04 22:00:03', NULL),
(344, 344, 171, 8, '2022-05-04 22:00:03', NULL),
(345, 345, 171, 8, '2022-05-04 22:00:03', NULL),
(346, 346, 171, 8, '2022-05-04 22:00:03', NULL),
(347, 347, 161, 7, '2022-05-04 22:00:04', NULL),
(348, 348, 161, 7, '2022-05-04 22:00:04', NULL),
(349, 349, 161, 7, '2022-05-04 22:00:04', NULL),
(350, 350, 161, 7, '2022-05-04 22:00:04', NULL),
(351, 351, 161, 7, '2022-05-04 22:00:04', NULL),
(352, 352, 161, 7, '2022-05-04 22:00:05', NULL),
(353, 353, 161, 7, '2022-05-04 22:00:05', NULL),
(354, 354, 161, 7, '2022-05-04 22:00:05', NULL),
(355, 355, 161, 7, '2022-05-04 22:00:06', NULL),
(356, 356, 161, 7, '2022-05-04 22:00:06', NULL),
(357, 357, 161, 7, '2022-05-04 22:00:06', NULL),
(358, 358, 161, 7, '2022-05-04 22:00:06', NULL),
(359, 359, 161, 7, '2022-05-04 22:00:07', NULL),
(360, 360, 161, 7, '2022-05-04 22:00:07', NULL),
(361, 361, 161, 7, '2022-05-04 22:00:07', NULL),
(362, 362, 161, 7, '2022-05-04 22:00:07', NULL),
(363, 363, 171, 8, '2022-05-04 22:00:08', NULL),
(364, 364, 171, 8, '2022-05-04 22:00:08', NULL),
(365, 365, 171, 8, '2022-05-04 22:00:08', NULL),
(366, 366, 171, 8, '2022-05-04 22:00:08', NULL),
(367, 367, 151, 7, '2022-05-04 22:00:08', NULL),
(368, 368, 161, 7, '2022-05-04 22:00:09', NULL),
(369, 369, 161, 7, '2022-05-04 22:00:09', NULL),
(370, 370, 161, 7, '2022-05-04 22:00:09', NULL),
(371, 371, 161, 7, '2022-05-04 22:00:09', NULL),
(372, 372, 151, 7, '2022-05-04 22:00:10', NULL),
(373, 373, 151, 7, '2022-05-04 22:00:10', NULL),
(374, 374, 151, 7, '2022-05-04 22:00:10', NULL),
(375, 375, 151, 7, '2022-05-04 22:00:10', NULL),
(376, 376, 151, 7, '2022-05-04 22:00:11', NULL),
(377, 377, 151, 7, '2022-05-04 22:00:11', NULL),
(378, 378, 151, 7, '2022-05-04 22:00:11', NULL),
(379, 379, 151, 7, '2022-05-04 22:00:11', NULL),
(380, 380, 151, 7, '2022-05-04 22:00:12', NULL),
(381, 381, 151, 7, '2022-05-04 22:00:12', NULL),
(382, 382, 151, 7, '2022-05-04 22:00:12', NULL),
(383, 383, 151, 7, '2022-05-04 22:00:12', NULL),
(384, 384, 151, 7, '2022-05-04 22:00:13', NULL),
(385, 385, 151, 7, '2022-05-04 22:00:13', NULL),
(386, 386, 151, 7, '2022-05-04 22:00:13', NULL),
(387, 387, 151, 7, '2022-05-04 22:00:13', NULL),
(388, 388, 151, 7, '2022-05-04 22:00:14', NULL),
(389, 389, 151, 7, '2022-05-04 22:00:14', NULL),
(390, 390, 171, 8, '2022-05-04 22:00:14', NULL),
(391, 391, 171, 8, '2022-05-04 22:00:14', NULL),
(392, 392, 171, 8, '2022-05-04 22:00:15', NULL),
(393, 393, 171, 8, '2022-05-04 22:00:15', NULL),
(394, 394, 171, 8, '2022-05-04 22:00:15', NULL),
(395, 395, 171, 8, '2022-05-04 22:00:15', NULL),
(396, 396, 171, 8, '2022-05-04 22:00:15', NULL),
(397, 397, 171, 8, '2022-05-04 22:00:15', NULL),
(398, 398, 171, 8, '2022-05-04 22:00:16', NULL),
(399, 399, 171, 8, '2022-05-04 22:00:16', NULL),
(400, 400, 171, 8, '2022-05-04 22:00:16', NULL),
(401, 401, 171, 8, '2022-05-04 22:00:16', NULL),
(402, 402, 171, 8, '2022-05-04 22:00:16', NULL),
(403, 403, 171, 8, '2022-05-04 22:00:16', NULL),
(404, 404, 171, 8, '2022-05-04 22:00:17', NULL),
(405, 405, 171, 8, '2022-05-04 22:00:17', NULL),
(406, 406, 171, 8, '2022-05-04 22:00:17', NULL),
(407, 407, 171, 8, '2022-05-04 22:00:17', NULL),
(408, 408, 171, 8, '2022-05-04 22:00:17', NULL),
(409, 409, 171, 8, '2022-05-04 22:00:18', NULL),
(410, 410, 171, 8, '2022-05-04 22:00:18', NULL),
(411, 411, 171, 8, '2022-05-04 22:00:18', NULL),
(412, 412, 171, 8, '2022-05-04 22:00:18', NULL),
(413, 413, 171, 8, '2022-05-04 22:00:18', NULL),
(414, 414, 171, 8, '2022-05-04 22:00:18', NULL),
(415, 415, 171, 8, '2022-05-04 22:00:19', NULL),
(416, 416, 171, 8, '2022-05-04 22:00:19', NULL),
(417, 417, 171, 8, '2022-05-04 22:00:19', NULL),
(418, 418, 161, 7, '2022-05-04 22:00:19', NULL),
(419, 419, 161, 7, '2022-05-04 22:00:20', NULL),
(420, 420, 161, 7, '2022-05-04 22:00:20', NULL),
(421, 421, 161, 7, '2022-05-04 22:00:20', NULL),
(422, 422, 161, 7, '2022-05-04 22:00:20', NULL),
(423, 423, 161, 7, '2022-05-04 22:00:21', NULL),
(424, 424, 161, 7, '2022-05-04 22:00:21', NULL),
(425, 425, 161, 7, '2022-05-04 22:00:21', NULL),
(426, 426, 161, 7, '2022-05-04 22:00:21', NULL),
(427, 427, 161, 7, '2022-05-04 22:00:22', NULL),
(428, 428, 161, 7, '2022-05-04 22:00:22', NULL),
(429, 429, 161, 7, '2022-05-04 22:00:22', NULL),
(430, 430, 161, 7, '2022-05-04 22:00:23', NULL),
(431, 431, 161, 7, '2022-05-04 22:00:23', NULL),
(432, 432, 161, 7, '2022-05-04 22:00:23', NULL),
(433, 433, 161, 7, '2022-05-04 22:00:23', NULL),
(434, 434, 161, 7, '2022-05-04 22:00:24', NULL),
(435, 435, 161, 7, '2022-05-04 22:00:24', NULL),
(436, 436, 161, 7, '2022-05-04 22:00:24', NULL),
(437, 437, 161, 7, '2022-05-04 22:00:24', NULL),
(438, 438, 161, 7, '2022-05-04 22:00:25', NULL),
(439, 439, 161, 7, '2022-05-04 22:00:25', NULL),
(440, 440, 161, 7, '2022-05-04 22:00:25', NULL),
(441, 441, 161, 7, '2022-05-04 22:00:26', NULL),
(442, 442, 161, 7, '2022-05-04 22:00:26', NULL),
(443, 443, 161, 7, '2022-05-04 22:00:26', NULL),
(444, 444, 161, 7, '2022-05-04 22:00:26', NULL),
(445, 445, 161, 7, '2022-05-04 22:00:27', NULL),
(446, 446, 161, 7, '2022-05-04 22:00:27', NULL),
(447, 447, 161, 7, '2022-05-04 22:00:27', NULL),
(448, 448, 161, 7, '2022-05-04 22:00:27', NULL),
(449, 449, 161, 7, '2022-05-04 22:00:28', NULL),
(450, 450, 161, 7, '2022-05-04 22:00:28', NULL),
(451, 451, 161, 7, '2022-05-04 22:00:28', NULL),
(452, 452, 161, 7, '2022-05-04 22:00:29', NULL),
(453, 453, 161, 7, '2022-05-04 22:00:29', NULL),
(454, 454, 161, 7, '2022-05-04 22:00:29', NULL),
(455, 455, 161, 7, '2022-05-04 22:00:29', NULL),
(456, 456, 161, 7, '2022-05-04 22:00:30', NULL),
(457, 457, 172, 8, '2022-05-04 22:00:30', NULL),
(458, 458, 172, 8, '2022-05-04 22:00:30', NULL),
(459, 459, 172, 8, '2022-05-04 22:00:30', NULL),
(460, 460, 172, 8, '2022-05-04 22:00:30', NULL),
(461, 461, 172, 8, '2022-05-04 22:00:31', NULL),
(462, 462, 172, 8, '2022-05-04 22:00:31', NULL),
(463, 463, 172, 8, '2022-05-04 22:00:31', NULL),
(464, 464, 172, 8, '2022-05-04 22:00:31', NULL),
(465, 465, 172, 8, '2022-05-04 22:00:31', NULL),
(466, 466, 172, 8, '2022-05-04 22:00:31', NULL),
(467, 467, 172, 8, '2022-05-04 22:00:32', NULL),
(468, 468, 172, 8, '2022-05-04 22:00:32', NULL),
(469, 469, 172, 8, '2022-05-04 22:00:32', NULL),
(470, 470, 172, 8, '2022-05-04 22:00:32', NULL),
(471, 471, 172, 8, '2022-05-04 22:00:32', NULL),
(472, 472, 172, 8, '2022-05-04 22:00:33', NULL),
(473, 473, 172, 8, '2022-05-04 22:00:33', NULL),
(474, 474, 172, 8, '2022-05-04 22:00:33', NULL),
(475, 475, 172, 8, '2022-05-04 22:00:33', NULL),
(476, 476, 172, 8, '2022-05-04 22:00:33', NULL),
(477, 477, 172, 8, '2022-05-04 22:00:33', NULL),
(478, 478, 172, 8, '2022-05-04 22:00:34', NULL),
(479, 479, 172, 8, '2022-05-04 22:00:34', NULL),
(480, 480, 172, 8, '2022-05-04 22:00:34', NULL),
(481, 481, 172, 8, '2022-05-04 22:00:34', NULL),
(482, 482, 172, 8, '2022-05-04 22:00:34', NULL),
(483, 483, 172, 8, '2022-05-04 22:00:35', NULL),
(484, 484, 172, 8, '2022-05-04 22:00:35', NULL),
(485, 485, 172, 8, '2022-05-04 22:00:35', NULL),
(486, 486, 172, 8, '2022-05-04 22:00:35', NULL),
(487, 487, 172, 8, '2022-05-04 22:00:35', NULL),
(488, 488, 172, 8, '2022-05-04 22:00:36', NULL),
(489, 489, 172, 8, '2022-05-04 22:00:36', NULL),
(490, 490, 172, 8, '2022-05-04 22:00:36', NULL),
(491, 491, 172, 8, '2022-05-04 22:00:36', NULL),
(492, 492, 172, 8, '2022-05-04 22:00:36', NULL),
(493, 493, 172, 8, '2022-05-04 22:00:36', NULL),
(494, 494, 172, 8, '2022-05-04 22:00:37', NULL),
(495, 495, 172, 8, '2022-05-04 22:00:37', NULL),
(496, 496, 172, 8, '2022-05-04 22:00:37', NULL),
(497, 497, 172, 8, '2022-05-04 22:00:37', NULL),
(498, 498, 151, 7, '2022-05-04 22:00:37', NULL),
(499, 499, 161, 7, '2022-05-04 22:00:38', NULL),
(500, 500, 161, 7, '2022-05-04 22:00:38', NULL),
(501, 501, 161, 7, '2022-05-04 22:00:38', NULL),
(502, 502, 161, 7, '2022-05-04 22:00:39', NULL),
(503, 503, 171, 8, '2022-05-04 22:00:39', NULL),
(504, 504, 171, 8, '2022-05-04 22:00:39', NULL),
(505, 505, 171, 8, '2022-05-04 22:00:39', NULL),
(506, 506, 171, 8, '2022-05-04 22:00:39', NULL),
(507, 507, 171, 8, '2022-05-04 22:00:39', NULL),
(508, 508, 171, 8, '2022-05-04 22:00:40', NULL),
(509, 509, 171, 8, '2022-05-04 22:00:40', NULL),
(510, 510, 171, 8, '2022-05-04 22:00:40', NULL),
(511, 511, 171, 8, '2022-05-04 22:00:40', NULL),
(512, 512, 171, 8, '2022-05-04 22:00:40', NULL),
(513, 513, 171, 8, '2022-05-04 22:00:41', NULL),
(514, 514, 171, 8, '2022-05-04 22:00:41', NULL),
(515, 515, 171, 8, '2022-05-04 22:00:41', NULL),
(516, 516, 171, 8, '2022-05-04 22:00:41', NULL),
(517, 517, 171, 8, '2022-05-04 22:00:41', NULL),
(518, 518, 171, 8, '2022-05-04 22:00:42', NULL),
(519, 519, 171, 8, '2022-05-04 22:00:42', NULL),
(520, 520, 171, 8, '2022-05-04 22:00:42', NULL),
(521, 521, 171, 8, '2022-05-04 22:00:42', NULL),
(522, 522, 171, 8, '2022-05-04 22:00:42', NULL),
(523, 523, 171, 8, '2022-05-04 22:00:42', NULL),
(524, 524, 181, 8, '2022-05-04 22:00:43', NULL),
(525, 525, 181, 8, '2022-05-04 22:00:43', NULL),
(526, 526, 181, 8, '2022-05-04 22:00:43', NULL),
(527, 527, 181, 8, '2022-05-04 22:00:43', NULL),
(528, 528, 181, 8, '2022-05-04 22:00:43', NULL),
(529, 529, 181, 8, '2022-05-04 22:00:43', NULL),
(530, 530, 181, 8, '2022-05-04 22:00:44', NULL),
(531, 531, 181, 8, '2022-05-04 22:00:44', NULL),
(532, 532, 181, 8, '2022-05-04 22:00:44', NULL),
(533, 533, 181, 8, '2022-05-04 22:00:44', NULL),
(534, 534, 181, 8, '2022-05-04 22:00:44', NULL),
(535, 535, 181, 8, '2022-05-04 22:00:45', NULL),
(536, 536, 181, 8, '2022-05-04 22:00:45', NULL),
(537, 537, 181, 8, '2022-05-04 22:00:45', NULL),
(538, 538, 181, 8, '2022-05-04 22:00:45', NULL),
(539, 539, 181, 8, '2022-05-04 22:00:45', NULL),
(540, 540, 181, 8, '2022-05-04 22:00:46', NULL),
(541, 541, 181, 8, '2022-05-04 22:00:46', NULL),
(542, 542, 181, 8, '2022-05-04 22:00:46', NULL),
(543, 543, 181, 8, '2022-05-04 22:00:46', NULL),
(544, 544, 181, 8, '2022-05-04 22:00:46', NULL),
(545, 545, 181, 8, '2022-05-04 22:00:46', NULL),
(546, 546, 181, 8, '2022-05-04 22:00:47', NULL),
(547, 547, 181, 8, '2022-05-04 22:00:47', NULL),
(548, 548, 181, 8, '2022-05-04 22:00:47', NULL),
(549, 549, 181, 8, '2022-05-04 22:00:47', NULL),
(550, 550, 181, 8, '2022-05-04 22:00:47', NULL),
(551, 551, 181, 8, '2022-05-04 22:00:48', NULL),
(552, 552, 171, 8, '2022-05-04 22:00:48', NULL),
(553, 553, 171, 8, '2022-05-04 22:00:48', NULL),
(554, 554, 171, 8, '2022-05-04 22:00:48', NULL),
(555, 555, 171, 8, '2022-05-04 22:00:48', NULL),
(556, 556, 171, 8, '2022-05-04 22:00:49', NULL),
(557, 557, 171, 8, '2022-05-04 22:00:49', NULL),
(558, 558, 171, 8, '2022-05-04 22:00:49', NULL),
(559, 559, 171, 8, '2022-05-04 22:00:49', NULL),
(560, 560, 171, 8, '2022-05-04 22:00:49', NULL),
(561, 561, 181, 8, '2022-05-04 22:00:49', NULL),
(562, 562, 181, 8, '2022-05-04 22:00:50', NULL),
(563, 563, 181, 8, '2022-05-04 22:00:50', NULL),
(564, 564, 181, 8, '2022-05-04 22:00:50', NULL),
(565, 565, 181, 8, '2022-05-04 22:00:50', NULL),
(566, 566, 181, 8, '2022-05-04 22:00:50', NULL),
(567, 567, 181, 8, '2022-05-04 22:00:51', NULL),
(568, 568, 181, 8, '2022-05-04 22:00:51', NULL),
(569, 569, 181, 8, '2022-05-04 22:00:51', NULL),
(570, 570, 181, 8, '2022-05-04 22:00:51', NULL),
(571, 571, 181, 8, '2022-05-04 22:00:51', NULL),
(572, 572, 181, 8, '2022-05-04 22:00:51', NULL),
(573, 573, 181, 8, '2022-05-04 22:00:52', NULL),
(574, 574, 181, 8, '2022-05-04 22:00:52', NULL),
(575, 575, 181, 8, '2022-05-04 22:00:52', NULL),
(576, 576, 181, 8, '2022-05-04 22:00:52', NULL),
(577, 577, 181, 8, '2022-05-04 22:00:52', NULL),
(578, 578, 181, 8, '2022-05-04 22:00:53', NULL),
(579, 579, 181, 8, '2022-05-04 22:00:53', NULL),
(580, 580, 181, 8, '2022-05-04 22:00:53', NULL),
(581, 581, 181, 8, '2022-05-04 22:00:53', NULL),
(582, 582, 181, 8, '2022-05-04 22:00:53', NULL),
(583, 583, 181, 8, '2022-05-04 22:00:53', NULL),
(584, 584, 181, 8, '2022-05-04 22:00:54', NULL),
(585, 585, 181, 8, '2022-05-04 22:00:54', NULL),
(586, 586, 181, 8, '2022-05-04 22:00:54', NULL),
(587, 587, 181, 8, '2022-05-04 22:00:54', NULL),
(588, 588, 181, 8, '2022-05-04 22:00:54', NULL),
(589, 589, 181, 8, '2022-05-04 22:00:55', NULL),
(590, 590, 181, 8, '2022-05-04 22:00:55', NULL),
(591, 591, 181, 8, '2022-05-04 22:00:55', NULL),
(592, 592, 181, 8, '2022-05-04 22:00:55', NULL),
(593, 593, 181, 8, '2022-05-04 22:00:55', NULL),
(594, 594, 181, 8, '2022-05-04 22:00:56', NULL),
(595, 595, 181, 8, '2022-05-04 22:00:56', NULL),
(596, 596, 181, 8, '2022-05-04 22:00:56', NULL),
(597, 597, 181, 8, '2022-05-04 22:00:56', NULL),
(598, 598, 181, 8, '2022-05-04 22:00:56', NULL),
(599, 599, 181, 8, '2022-05-04 22:00:57', NULL),
(600, 600, 181, 8, '2022-05-04 22:00:57', NULL),
(601, 601, 181, 8, '2022-05-04 22:00:57', NULL),
(602, 602, 181, 8, '2022-05-04 22:00:57', NULL),
(603, 603, 181, 8, '2022-05-04 22:00:57', NULL),
(604, 604, 181, 8, '2022-05-04 22:00:57', NULL),
(605, 605, 181, 8, '2022-05-04 22:00:58', NULL),
(606, 606, 181, 8, '2022-05-04 22:00:58', NULL),
(607, 607, 181, 8, '2022-05-04 22:00:58', NULL),
(608, 608, 181, 8, '2022-05-04 22:00:58', NULL),
(609, 609, 181, 8, '2022-05-04 22:00:58', NULL),
(610, 610, 181, 8, '2022-05-04 22:00:59', NULL),
(611, 611, 181, 8, '2022-05-04 22:00:59', NULL),
(612, 612, 181, 8, '2022-05-04 22:00:59', NULL),
(613, 613, 181, 8, '2022-05-04 22:00:59', NULL),
(614, 614, 181, 8, '2022-05-04 22:00:59', NULL),
(615, 615, 181, 8, '2022-05-04 22:00:59', NULL),
(616, 616, 181, 8, '2022-05-04 22:01:00', NULL),
(617, 617, 181, 8, '2022-05-04 22:01:00', NULL),
(618, 618, 181, 8, '2022-05-04 22:01:00', NULL),
(619, 619, 181, 8, '2022-05-04 22:01:00', NULL),
(620, 620, 181, 8, '2022-05-04 22:01:00', NULL),
(621, 621, 181, 8, '2022-05-04 22:01:01', NULL),
(622, 622, 181, 8, '2022-05-04 22:01:01', NULL),
(623, 623, 181, 8, '2022-05-04 22:01:01', NULL),
(624, 624, 181, 8, '2022-05-04 22:01:01', NULL),
(625, 625, 181, 8, '2022-05-04 22:01:01', NULL),
(626, 626, 181, 8, '2022-05-04 22:01:02', NULL),
(627, 627, 181, 8, '2022-05-04 22:01:02', NULL),
(628, 628, 181, 8, '2022-05-04 22:01:02', NULL),
(629, 629, 181, 8, '2022-05-04 22:01:02', NULL),
(630, 630, 181, 8, '2022-05-04 22:01:02', NULL),
(631, 631, 181, 8, '2022-05-04 22:01:03', NULL),
(632, 632, 181, 8, '2022-05-04 22:01:03', NULL),
(633, 633, 181, 8, '2022-05-04 22:01:03', NULL),
(634, 634, 181, 8, '2022-05-04 22:01:03', NULL),
(635, 635, 181, 8, '2022-05-04 22:01:03', NULL),
(636, 636, 181, 8, '2022-05-04 22:01:03', NULL),
(637, 637, 181, 8, '2022-05-04 22:01:04', NULL),
(638, 638, 181, 8, '2022-05-04 22:01:04', NULL),
(639, 639, 181, 8, '2022-05-04 22:01:04', NULL),
(640, 640, 181, 8, '2022-05-04 22:01:04', NULL),
(641, 641, 181, 8, '2022-05-04 22:01:04', NULL),
(642, 642, 181, 8, '2022-05-04 22:01:05', NULL),
(643, 643, 181, 8, '2022-05-04 22:01:05', NULL),
(644, 644, 181, 8, '2022-05-04 22:01:05', NULL),
(645, 645, 181, 8, '2022-05-04 22:01:05', NULL),
(646, 646, 181, 8, '2022-05-04 22:01:05', NULL),
(647, 647, 181, 8, '2022-05-04 22:01:05', NULL),
(648, 648, 181, 8, '2022-05-04 22:01:06', NULL),
(649, 649, 171, 8, '2022-05-04 22:01:06', NULL),
(650, 650, 171, 8, '2022-05-04 22:01:06', NULL),
(651, 651, 171, 8, '2022-05-04 22:01:06', NULL),
(652, 652, 171, 8, '2022-05-04 22:01:06', NULL),
(653, 653, 171, 8, '2022-05-04 22:01:07', NULL),
(654, 654, 171, 8, '2022-05-04 22:01:07', NULL),
(655, 655, 171, 8, '2022-05-04 22:01:07', NULL),
(656, 656, 171, 8, '2022-05-04 22:01:07', NULL),
(657, 657, 171, 8, '2022-05-04 22:01:07', NULL),
(658, 658, 171, 8, '2022-05-04 22:01:08', NULL),
(659, 659, 171, 8, '2022-05-04 22:01:08', NULL),
(660, 660, 171, 8, '2022-05-04 22:01:08', NULL),
(661, 661, 171, 8, '2022-05-04 22:01:08', NULL),
(662, 662, 171, 8, '2022-05-04 22:01:08', NULL),
(663, 663, 171, 8, '2022-05-04 22:01:08', NULL),
(664, 664, 171, 8, '2022-05-04 22:01:09', NULL),
(665, 665, 171, 8, '2022-05-04 22:01:09', NULL),
(666, 666, 171, 8, '2022-05-04 22:01:09', NULL),
(667, 667, 171, 8, '2022-05-04 22:01:09', NULL),
(668, 668, 171, 8, '2022-05-04 22:01:09', NULL),
(669, 669, 171, 8, '2022-05-04 22:01:10', NULL),
(670, 670, 171, 8, '2022-05-04 22:01:10', NULL),
(671, 671, 171, 8, '2022-05-04 22:01:10', NULL),
(672, 672, 182, 8, '2022-05-04 22:01:10', NULL),
(673, 673, 182, 8, '2022-05-04 22:01:10', NULL),
(674, 674, 182, 8, '2022-05-04 22:01:10', NULL),
(675, 675, 182, 8, '2022-05-04 22:01:11', NULL),
(676, 676, 182, 8, '2022-05-04 22:01:11', NULL),
(677, 677, 182, 8, '2022-05-04 22:01:11', NULL),
(678, 678, 182, 8, '2022-05-04 22:01:11', NULL),
(679, 679, 182, 8, '2022-05-04 22:01:11', NULL),
(680, 680, 182, 8, '2022-05-04 22:01:12', NULL),
(681, 681, 182, 8, '2022-05-04 22:01:12', NULL),
(682, 682, 182, 8, '2022-05-04 22:01:12', NULL),
(683, 683, 182, 8, '2022-05-04 22:01:12', NULL),
(684, 684, 182, 8, '2022-05-04 22:01:12', NULL),
(685, 685, 182, 8, '2022-05-04 22:01:13', NULL),
(686, 686, 182, 8, '2022-05-04 22:01:13', NULL),
(687, 687, 182, 8, '2022-05-04 22:01:13', NULL),
(688, 688, 151, 7, '2022-05-04 22:01:13', NULL),
(689, 689, 151, 7, '2022-05-04 22:01:14', NULL),
(690, 690, 151, 7, '2022-05-04 22:01:14', NULL),
(691, 691, 161, 7, '2022-05-04 22:01:14', NULL),
(692, 692, 161, 7, '2022-05-04 22:01:14', NULL),
(693, 693, 161, 7, '2022-05-04 22:01:15', NULL),
(694, 694, 161, 7, '2022-05-04 22:01:15', NULL),
(695, 695, 161, 7, '2022-05-04 22:01:15', NULL),
(696, 696, 161, 7, '2022-05-04 22:01:16', NULL),
(697, 697, 161, 7, '2022-05-04 22:01:16', NULL),
(698, 698, 161, 7, '2022-05-04 22:01:16', NULL),
(699, 699, 161, 7, '2022-05-04 22:01:17', NULL),
(700, 700, 161, 7, '2022-05-04 22:01:17', NULL),
(701, 701, 161, 7, '2022-05-04 22:01:17', NULL),
(702, 702, 161, 7, '2022-05-04 22:01:18', NULL),
(703, 703, 161, 7, '2022-05-04 22:01:18', NULL),
(704, 704, 161, 7, '2022-05-04 22:01:18', NULL),
(705, 705, 161, 7, '2022-05-04 22:01:18', NULL),
(706, 706, 161, 7, '2022-05-04 22:01:19', NULL),
(707, 707, 161, 7, '2022-05-04 22:01:19', NULL),
(708, 708, 161, 7, '2022-05-04 22:01:19', NULL),
(709, 709, 161, 7, '2022-05-04 22:01:20', NULL),
(710, 710, 161, 7, '2022-05-04 22:01:20', NULL),
(711, 711, 161, 7, '2022-05-04 22:01:20', NULL),
(712, 712, 161, 7, '2022-05-04 22:01:21', NULL),
(713, 713, 161, 7, '2022-05-04 22:01:21', NULL),
(714, 714, 161, 7, '2022-05-04 22:01:21', NULL),
(715, 715, 161, 7, '2022-05-04 22:01:22', NULL),
(716, 716, 161, 7, '2022-05-04 22:01:22', NULL),
(717, 717, 181, 8, '2022-05-04 22:01:22', NULL),
(718, 718, 181, 8, '2022-05-04 22:01:22', NULL),
(719, 719, 181, 8, '2022-05-04 22:01:22', NULL),
(720, 720, 181, 8, '2022-05-04 22:01:23', NULL),
(721, 721, 181, 8, '2022-05-04 22:01:23', NULL),
(722, 722, 181, 8, '2022-05-04 22:01:23', NULL),
(723, 723, 181, 8, '2022-05-04 22:01:23', NULL),
(724, 724, 181, 8, '2022-05-04 22:01:23', NULL),
(725, 725, 181, 8, '2022-05-04 22:01:24', NULL),
(726, 726, 171, 8, '2022-05-04 22:01:24', NULL),
(727, 727, 171, 8, '2022-05-04 22:01:24', NULL),
(728, 728, 171, 8, '2022-05-04 22:01:24', NULL),
(729, 729, 171, 8, '2022-05-04 22:01:24', NULL),
(730, 730, 171, 8, '2022-05-04 22:01:24', NULL),
(731, 731, 171, 8, '2022-05-04 22:01:25', NULL),
(732, 732, 171, 8, '2022-05-04 22:01:25', NULL),
(733, 733, 171, 8, '2022-05-04 22:01:25', NULL),
(734, 734, 171, 8, '2022-05-04 22:01:25', NULL),
(735, 735, 171, 8, '2022-05-04 22:01:25', NULL),
(736, 736, 171, 8, '2022-05-04 22:01:26', NULL),
(737, 737, 171, 8, '2022-05-04 22:01:26', NULL),
(738, 738, 171, 8, '2022-05-04 22:01:26', NULL),
(739, 739, 171, 8, '2022-05-04 22:01:26', NULL),
(740, 740, 171, 8, '2022-05-04 22:01:26', NULL),
(741, 741, 171, 8, '2022-05-04 22:01:27', NULL),
(742, 742, 171, 8, '2022-05-04 22:01:27', NULL),
(743, 743, 171, 8, '2022-05-04 22:01:27', NULL),
(744, 744, 171, 8, '2022-05-04 22:01:27', NULL),
(745, 745, 171, 8, '2022-05-04 22:01:27', NULL),
(746, 746, 151, 7, '2022-05-04 22:01:28', NULL),
(747, 747, 151, 7, '2022-05-04 22:01:28', NULL),
(748, 748, 151, 7, '2022-05-04 22:01:28', NULL),
(749, 749, 151, 7, '2022-05-04 22:01:28', NULL),
(750, 750, 161, 7, '2022-05-04 22:01:29', NULL),
(751, 751, 161, 7, '2022-05-04 22:01:29', NULL),
(752, 752, 161, 7, '2022-05-04 22:01:29', NULL),
(753, 753, 161, 7, '2022-05-04 22:01:30', NULL),
(754, 754, 161, 7, '2022-05-04 22:01:30', NULL),
(755, 755, 161, 7, '2022-05-04 22:01:30', NULL),
(756, 756, 161, 7, '2022-05-04 22:01:31', NULL),
(757, 757, 161, 7, '2022-05-04 22:01:31', NULL),
(758, 758, 161, 7, '2022-05-04 22:01:31', NULL),
(759, 759, 161, 7, '2022-05-04 22:01:32', NULL),
(760, 760, 161, 7, '2022-05-04 22:01:32', NULL),
(761, 761, 161, 7, '2022-05-04 22:01:32', NULL),
(762, 762, 161, 7, '2022-05-04 22:01:33', NULL),
(763, 763, 161, 7, '2022-05-04 22:01:33', NULL),
(764, 764, 161, 7, '2022-05-04 22:01:33', NULL),
(765, 765, 161, 7, '2022-05-04 22:01:34', NULL),
(766, 766, 161, 7, '2022-05-04 22:01:34', NULL),
(767, 767, 161, 7, '2022-05-04 22:01:34', NULL),
(768, 768, 161, 7, '2022-05-04 22:01:34', NULL),
(769, 769, 161, 7, '2022-05-04 22:01:35', NULL),
(770, 770, 161, 7, '2022-05-04 22:01:35', NULL),
(771, 771, 161, 7, '2022-05-04 22:01:36', NULL),
(772, 772, 161, 7, '2022-05-04 22:01:36', NULL),
(773, 773, 151, 7, '2022-05-04 22:01:36', NULL),
(774, 774, 151, 7, '2022-05-04 22:01:36', NULL),
(775, 775, 151, 7, '2022-05-04 22:01:37', NULL),
(776, 776, 151, 7, '2022-05-04 22:01:37', NULL),
(777, 777, 161, 7, '2022-05-04 22:01:37', NULL),
(778, 778, 161, 7, '2022-05-04 22:01:38', NULL),
(779, 779, 161, 7, '2022-05-04 22:01:38', NULL),
(780, 780, 161, 7, '2022-05-04 22:01:38', NULL),
(781, 781, 161, 7, '2022-05-04 22:01:39', NULL),
(782, 782, 161, 7, '2022-05-04 22:01:39', NULL),
(783, 783, 161, 7, '2022-05-04 22:01:39', NULL),
(784, 784, 161, 7, '2022-05-04 22:01:40', NULL),
(785, 785, 161, 7, '2022-05-04 22:01:40', NULL),
(786, 786, 161, 7, '2022-05-04 22:01:40', NULL),
(787, 787, 161, 7, '2022-05-04 22:01:41', NULL),
(788, 788, 161, 7, '2022-05-04 22:01:41', NULL),
(789, 789, 161, 7, '2022-05-04 22:01:41', NULL),
(790, 790, 161, 7, '2022-05-04 22:01:42', NULL),
(791, 791, 161, 7, '2022-05-04 22:01:42', NULL),
(792, 792, 161, 7, '2022-05-04 22:01:42', NULL),
(793, 793, 181, 8, '2022-05-04 22:01:43', NULL),
(794, 794, 181, 8, '2022-05-04 22:01:43', NULL),
(795, 795, 181, 8, '2022-05-04 22:01:43', NULL),
(796, 796, 181, 8, '2022-05-04 22:01:43', NULL),
(797, 797, 181, 8, '2022-05-04 22:01:43', NULL),
(798, 798, 181, 8, '2022-05-04 22:01:43', NULL),
(799, 799, 181, 8, '2022-05-04 22:01:44', NULL),
(800, 800, 181, 8, '2022-05-04 22:01:44', NULL),
(801, 801, 181, 8, '2022-05-04 22:01:44', NULL),
(802, 802, 181, 8, '2022-05-04 22:01:44', NULL),
(803, 803, 181, 8, '2022-05-04 22:01:44', NULL),
(804, 804, 181, 8, '2022-05-04 22:01:45', NULL),
(805, 805, 181, 8, '2022-05-04 22:01:45', NULL),
(806, 806, 181, 8, '2022-05-04 22:01:45', NULL),
(807, 807, 181, 8, '2022-05-04 22:01:45', NULL),
(808, 808, 181, 8, '2022-05-04 22:01:45', NULL),
(809, 809, 181, 8, '2022-05-04 22:01:46', NULL),
(810, 810, 181, 8, '2022-05-04 22:01:46', NULL),
(811, 811, 151, 7, '2022-05-04 22:01:46', NULL),
(812, 812, 151, 7, '2022-05-04 22:01:46', NULL),
(813, 813, 151, 7, '2022-05-04 22:01:47', NULL),
(814, 814, 151, 7, '2022-05-04 22:01:47', NULL),
(815, 815, 151, 7, '2022-05-04 22:01:47', NULL),
(816, 816, 151, 7, '2022-05-04 22:01:48', NULL),
(817, 817, 151, 7, '2022-05-04 22:01:48', NULL),
(818, 818, 151, 7, '2022-05-04 22:01:48', NULL),
(819, 819, 151, 7, '2022-05-04 22:01:49', NULL),
(820, 820, 151, 7, '2022-05-04 22:01:49', NULL),
(821, 821, 171, 8, '2022-05-04 22:01:49', NULL),
(822, 822, 171, 8, '2022-05-04 22:01:50', NULL),
(823, 823, 171, 8, '2022-05-04 22:01:50', NULL),
(824, 824, 171, 8, '2022-05-04 22:01:50', NULL),
(825, 825, 171, 8, '2022-05-04 22:01:50', NULL),
(826, 826, 171, 8, '2022-05-04 22:01:50', NULL),
(827, 827, 171, 8, '2022-05-04 22:01:51', NULL),
(828, 828, 171, 8, '2022-05-04 22:01:51', NULL),
(829, 829, 171, 8, '2022-05-04 22:01:51', NULL),
(830, 830, 171, 8, '2022-05-04 22:01:51', NULL),
(831, 831, 171, 8, '2022-05-04 22:01:51', NULL),
(832, 832, 171, 8, '2022-05-04 22:01:51', NULL),
(833, 833, 2710, 25, '2022-05-04 22:01:52', NULL),
(834, 834, 2710, 25, '2022-05-04 22:01:52', NULL),
(835, 835, 2810, 25, '2022-05-04 22:01:52', NULL),
(836, 836, 2810, 25, '2022-05-04 22:01:53', NULL),
(837, 837, 4610, 40, '2022-05-04 22:01:53', NULL),
(838, 838, 4712, 40, '2022-05-04 22:01:53', NULL);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tlp_ekurunler_tbl`
--

CREATE TABLE `tlp_ekurunler_tbl` (
  `id` int(11) NOT NULL,
  `oid` int(11) NOT NULL,
  `urunkodu` int(8) NOT NULL,
  `fiyat` double NOT NULL,
  `taleptarihi` datetime NOT NULL,
  `basimtarihi` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tlp_g_anadersler_tbl`
--

CREATE TABLE `tlp_g_anadersler_tbl` (
  `id` int(11) NOT NULL,
  `oid` int(11) NOT NULL,
  `dersid` int(8) NOT NULL,
  `fiyat` double NOT NULL,
  `taleptarihi` datetime NOT NULL,
  `basimtarihi` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tlp_g_serbestler_tbl`
--

CREATE TABLE `tlp_g_serbestler_tbl` (
  `id` int(11) NOT NULL,
  `oid` int(11) NOT NULL,
  `dersid` int(8) NOT NULL,
  `fiyat` double NOT NULL,
  `taleptarihi` datetime NOT NULL,
  `basimtarihi` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tlp_nobetyeri_tbl`
--

CREATE TABLE `tlp_nobetyeri_tbl` (
  `id` int(11) NOT NULL,
  `oid` int(11) NOT NULL,
  `sablon_adi` varchar(16) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tlp_nobetyeri_tbl`
--

INSERT INTO `tlp_nobetyeri_tbl` (`id`, `oid`, `sablon_adi`) VALUES
(2, 835, '3_KAT'),
(3, 2, '2_KAT'),
(4, 834, '3_KAT');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tlp_ogrencilistesi_tbl`
--

CREATE TABLE `tlp_ogrencilistesi_tbl` (
  `id` int(11) NOT NULL,
  `oid` int(11) NOT NULL,
  `numara` int(8) NOT NULL,
  `adisoyadi` varchar(64) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tlp_ogrencilistesi_tbl`
--

INSERT INTO `tlp_ogrencilistesi_tbl` (`id`, `oid`, `numara`, `adisoyadi`) VALUES
(1, 2, 12, 'Mahmut Kök'),
(2, 2, 13, 'Nehir Kök'),
(3, 2, 14, 'Muhammet Buğra Kök'),
(4, 2, 55, 'Gülcan Kök');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tlp_ogretmenbilgileri_tbl`
--

CREATE TABLE `tlp_ogretmenbilgileri_tbl` (
  `oid` int(11) NOT NULL,
  `yili` varchar(14) COLLATE utf8_turkish_ci NOT NULL,
  `adisoyadi` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `brans` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `il` varchar(32) COLLATE utf8_turkish_ci NOT NULL,
  `ilce` varchar(32) COLLATE utf8_turkish_ci NOT NULL,
  `kurumkodu` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `okuladi` varchar(128) COLLATE utf8_turkish_ci NOT NULL,
  `sinif` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `sube` varchar(32) COLLATE utf8_turkish_ci NOT NULL,
  `muduradi` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `mudurunvani` varchar(32) COLLATE utf8_turkish_ci NOT NULL,
  `cep` varchar(16) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `eposta` varchar(64) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `adres` varchar(256) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `aciklama` varchar(512) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `bayi` varchar(16) COLLATE utf8_turkish_ci NOT NULL,
  `logoadi` varchar(64) COLLATE utf8_turkish_ci NOT NULL DEFAULT '',
  `kayittarihi` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tlp_ogretmenbilgileri_tbl`
--

INSERT INTO `tlp_ogretmenbilgileri_tbl` (`oid`, `yili`, `adisoyadi`, `brans`, `il`, `ilce`, `kurumkodu`, `okuladi`, `sinif`, `sube`, `muduradi`, `mudurunvani`, `cep`, `eposta`, `adres`, `aciklama`, `bayi`, `logoadi`, `kayittarihi`) VALUES
(1, '2022-2023', 'Ülkü KAHRAMAN', 'Sınıf Öğretmeni', 'AĞRI', 'Merkez', '0', 'ATATÜRK İLKOKULU ', '3', 'B', 'Ersin DOĞAN', 'Okul Müdürü', '', '', 'ÜLKÜ KAHRAMAN', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:58:59'),
(2, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '0', 'A', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:58:59'),
(3, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '0', 'B', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:58:59'),
(4, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '1', 'A', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:00'),
(5, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '1', 'B', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:00'),
(6, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '1', 'C', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:00'),
(7, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '1', 'D', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:00'),
(8, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '1', 'E', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:00'),
(9, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '1', 'F', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:01'),
(10, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '1', 'G', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:01'),
(11, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '2', 'A', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:01'),
(12, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '2', 'B', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:01'),
(13, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '2', 'C', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:01'),
(14, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '2', 'D', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:01'),
(15, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '2', 'E', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:02'),
(16, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '2', 'F', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:02'),
(17, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '3', 'A', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:02'),
(18, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '3', 'B', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:02'),
(19, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '3', 'C', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:02'),
(20, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '3', 'D', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:02'),
(21, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '3', 'E', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:03'),
(22, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '3', 'F', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:03'),
(23, '2022-2023', 'Özel Eğitim Sınıfı .', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '4', '….', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'ÖZEL EGİTİM', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:03'),
(24, '2022-2023', 'Özel Eğitim Sınıfı ..', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '4', '….', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'ÖZEL EGİTİM', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:03'),
(25, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '4', 'A', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:03'),
(26, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '4', 'B', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:04'),
(27, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '4', 'C', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:04'),
(28, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '4', 'D', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:04'),
(29, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', '80. Yıl İlkokulu', '4', 'E', 'İbrahim ONBAŞI', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:04'),
(30, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '5', 'A', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:04'),
(31, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '5', 'B', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:04'),
(32, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '5', 'C', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:05'),
(33, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '5', 'D', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:05'),
(34, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '5', 'E', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:05'),
(35, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '5', 'F', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:05'),
(36, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '5', 'G', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:05'),
(37, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '5', 'H', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:05'),
(38, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '6', 'A', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:06'),
(39, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '6', 'B', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:06'),
(40, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '6', 'C', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:06'),
(41, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '6', 'D', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:06'),
(42, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '6', 'E', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:06'),
(43, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '6', 'F', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:06'),
(44, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '6', 'G', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:07'),
(45, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '7', 'A', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:07'),
(46, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '7', 'B', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:07'),
(47, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '7', 'C', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:07'),
(48, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '7', 'D', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:07'),
(49, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '7', 'E', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:07'),
(50, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '7', 'F', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:08'),
(51, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '7', 'G', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:08'),
(52, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '7', 'H', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:08'),
(53, '2022-2023', 'Özel Eğitim Sınıfı .', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '8', '….', 'İnan BİRLİK', 'Okul Müdürü', '', '', 'ÖZEL EGİTİM', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:08'),
(54, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '8', 'A', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:08'),
(55, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '8', 'B', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:09'),
(56, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '8', 'C', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:09'),
(57, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '8', 'D', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:09'),
(58, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '8', 'E', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:09'),
(59, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '8', 'F', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:09'),
(60, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '8', 'G', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:09'),
(61, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '8', 'H', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:10'),
(62, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '1', '….', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:10'),
(63, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '1', 'A', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:10'),
(64, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '1', 'B', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:10'),
(65, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '1', 'C', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:10'),
(66, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '1', 'D', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:10'),
(67, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '1', 'E', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:11'),
(68, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '1', 'F', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:11'),
(69, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '1', 'G', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:11'),
(70, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '2', 'A', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:11'),
(71, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '2', 'B', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:11'),
(72, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '2', 'C', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:12'),
(73, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '2', 'D', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:12'),
(74, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '2', 'E', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:12'),
(75, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '2', 'F', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:12'),
(76, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '2', 'G', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:12'),
(77, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '2', 'H', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:13'),
(78, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '3', 'A', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'MAVİ', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:13'),
(79, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '3', 'B', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'MAVİ', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:13'),
(80, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '3', 'C', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'MAVİ', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:13'),
(81, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '3', 'D', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'MAVİ', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:13'),
(82, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '3', 'E', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'MAVİ', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:13'),
(83, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '4', 'A', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:14'),
(84, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '4', 'B', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:14'),
(85, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '4', 'C', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:14'),
(86, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '4', 'D', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:14'),
(87, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '4', 'E', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:14'),
(88, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Akhisar İlkokulu', '4', 'F', 'Özgür GÜMÜŞ', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:15'),
(89, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '0', 'A', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:15'),
(90, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '0', 'B', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:15'),
(91, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '0', 'C', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:15'),
(92, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '0', 'D', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:15'),
(93, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '1', 'A', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:16'),
(94, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '1', 'B', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:16'),
(95, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '1', 'C', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:16'),
(96, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '1', 'D', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:16'),
(97, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '1', 'E', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:16'),
(98, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '1', 'F', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:16'),
(99, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '2', 'A', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:17'),
(100, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '2', 'B', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:17'),
(101, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '2', 'C', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:17'),
(102, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '2', 'D', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:17'),
(103, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '2', 'E', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:17'),
(104, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '3', 'A', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:18'),
(105, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '3', 'B', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:18'),
(106, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '3', 'C', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:18'),
(107, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '3', 'D', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:18'),
(108, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '3', 'E', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:18'),
(109, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '4', 'A', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:19'),
(110, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '4', 'B', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:19'),
(111, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '4', 'C', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:19'),
(112, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '4', 'D', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:19'),
(113, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '4', 'E', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:19'),
(114, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt İlkokulu', '4', 'F', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:20'),
(115, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '5', 'A', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:20'),
(116, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '5', 'B', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:20'),
(117, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '5', 'C', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:20'),
(118, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '5', 'D', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:20'),
(119, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '5', 'E', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:20'),
(120, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '5', 'F', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:21'),
(121, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '6', 'A', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:21'),
(122, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '6', 'B', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:21'),
(123, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '6', 'C', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:21'),
(124, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '6', 'D', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:21'),
(125, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '6', 'E', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:21'),
(126, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '6', 'F', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:22'),
(127, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '7', 'A', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:22'),
(128, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '7', 'B', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:22'),
(129, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '7', 'C', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:22'),
(130, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '7', 'D', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:22'),
(131, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '8', 'A', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:23'),
(132, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '8', 'B', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:23'),
(133, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '8', 'C', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:23'),
(134, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '8', 'D', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:23'),
(135, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Alanyurt Ortaokulu', '8', 'E', 'Ahmet TÜRKYILMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:23'),
(136, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Atatürk Ortaokulu', '5', 'A', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:23'),
(137, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Atatürk Ortaokulu', '5', 'B', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:24'),
(138, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Atatürk Ortaokulu', '5', 'C', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:24'),
(139, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Atatürk Ortaokulu', '6', 'A', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:24'),
(140, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Atatürk Ortaokulu', '6', 'B', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:24'),
(141, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Atatürk Ortaokulu', '6', 'C', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:24'),
(142, '2022-2023', 'Özel Eğitim Sınıfı .', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Atatürk Ortaokulu', '6', 'D', '………. ……….', 'Okul Müdürü', '', '', 'ÖZEL EGİTİM', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:24'),
(143, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Atatürk Ortaokulu', '7', 'A', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:25'),
(144, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Atatürk Ortaokulu', '7', 'B', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:25'),
(145, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Atatürk Ortaokulu', '7', 'C', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:25'),
(146, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Atatürk Ortaokulu', '8', 'A', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:25'),
(147, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Atatürk Ortaokulu', '8', 'B', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:25'),
(148, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Atatürk Ortaokulu', '8', 'C', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:26'),
(149, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '5', 'A', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:26'),
(150, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '5', 'B', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:26'),
(151, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '5', 'C', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:26'),
(152, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '5', 'D', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:26'),
(153, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '5', 'E', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:26'),
(154, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '5', 'F', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:27'),
(155, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '5', 'G', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:27'),
(156, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '6', 'A', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:27'),
(157, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '6', 'B', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:27'),
(158, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '6', 'C', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:27'),
(159, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '6', 'D', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:27'),
(160, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '6', 'E', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:28'),
(161, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '6', 'F', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:28'),
(162, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '6', 'G', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:28'),
(163, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '6', 'H', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:28'),
(164, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '7', 'A', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:28'),
(165, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '7', 'B', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:28'),
(166, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '7', 'C', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:29'),
(167, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '7', 'D', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:29'),
(168, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '7', 'E', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:29'),
(169, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '7', 'F', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:29'),
(170, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '7', 'G', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:29'),
(171, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '7', 'H', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:30'),
(172, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '8', 'A', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:30'),
(173, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '8', 'B', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:30'),
(174, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '8', 'C', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:30'),
(175, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Bak Yapı Ali Bakgör Ortaokulu', '8', 'D', 'Orhan ERDOĞAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:30'),
(176, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '0', 'A', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:30'),
(177, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '0', 'B', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:31'),
(178, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '0', 'C', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:31'),
(179, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '0', 'D', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:31'),
(180, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '1', '….', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', 'ŞUBESİZ', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:31'),
(181, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '1', 'A', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:31'),
(182, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '1', 'B', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:32'),
(183, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '1', 'C', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:32'),
(184, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '1', 'D', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:32'),
(185, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '1', 'E', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:32'),
(186, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '1', 'F', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:32'),
(187, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '2', 'A', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:33'),
(188, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '2', 'B', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:33'),
(189, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '2', 'C', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:33'),
(190, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '2', 'D', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:33'),
(191, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '2', 'E', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:33'),
(192, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '2', 'F', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:33'),
(193, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '3', 'A', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:34'),
(194, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '3', 'B', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:34'),
(195, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '3', 'C', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:34'),
(196, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '3', 'D', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:34'),
(197, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '3', 'E', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:34'),
(198, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '3', 'F', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:35'),
(199, '2022-2023', 'Özel Eğitim Sınıfı .', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '4', '….', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:35'),
(200, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '4', 'A', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:35'),
(201, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '4', 'B', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:35'),
(202, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '4', 'C', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:35'),
(203, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '4', 'D', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:36'),
(204, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '4', 'E', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:36'),
(205, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Cemil Sönmez İlkokulu', '4', 'F', 'Sezanur AVŞAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:36'),
(206, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '0', 'A', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:36'),
(207, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '0', 'B', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:36'),
(208, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '0', 'C', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:37'),
(209, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '1', 'A', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:37'),
(210, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '1', 'B', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:37'),
(211, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '1', 'C', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:37'),
(212, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '1', 'D', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:37'),
(213, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '1', 'E', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:38'),
(214, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '2', 'A', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:38');
INSERT INTO `tlp_ogretmenbilgileri_tbl` (`oid`, `yili`, `adisoyadi`, `brans`, `il`, `ilce`, `kurumkodu`, `okuladi`, `sinif`, `sube`, `muduradi`, `mudurunvani`, `cep`, `eposta`, `adres`, `aciklama`, `bayi`, `logoadi`, `kayittarihi`) VALUES
(215, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '2', 'B', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:38'),
(216, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '2', 'C', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:38'),
(217, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '2', 'D', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:38'),
(218, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '2', 'E', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:39'),
(219, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '2', 'F', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:39'),
(220, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '3', 'A', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:39'),
(221, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '3', 'B', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:39'),
(222, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '3', 'C', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:39'),
(223, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '3', 'D', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:40'),
(224, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '3', 'E', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:40'),
(225, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '4', 'A', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:40'),
(226, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '4', 'B', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:40'),
(227, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '4', 'C', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:40'),
(228, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Doğan Yelken İlkokulu', '4', 'D', 'Mustafa ÖZKAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:41'),
(229, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '5', 'A', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:41'),
(230, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '5', 'B', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:41'),
(231, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '5', 'C', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:41'),
(232, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '5', 'D', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:41'),
(233, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '5', 'E', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:41'),
(234, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '6', 'A', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:42'),
(235, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '6', 'B', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:42'),
(236, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '6', 'C', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:42'),
(237, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '6', 'D', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:42'),
(238, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '6', 'E', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:42'),
(239, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '7', 'A', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:43'),
(240, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '7', 'B', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:43'),
(241, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '7', 'C', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:43'),
(242, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '7', 'D', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:43'),
(243, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '7', 'E', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:43'),
(244, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '7', 'F', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:43'),
(245, '2022-2023', 'Özel Eğitim Sınıfı .', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '8', '….', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', 'ÖZEL EGİTİM', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:44'),
(246, '2022-2023', 'Özel Eğitim Sınıfı .', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '8', '….', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', 'ÖZEL EGİTİM', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:44'),
(247, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '8', 'A', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:44'),
(248, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '8', 'B', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:44'),
(249, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '8', 'C', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:44'),
(250, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '8', 'D', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:44'),
(251, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '8', 'E', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:45'),
(252, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '8', 'F', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:45'),
(253, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Edebey  Ortaokulu', '5', 'A', 'Eser KIŞLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:45'),
(254, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Edebey  Ortaokulu', '6', 'A', 'Eser KIŞLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:45'),
(255, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Edebey  Ortaokulu', '7', 'A', 'Eser KIŞLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:45'),
(256, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Edebey  Ortaokulu', '8', 'A', 'Eser KIŞLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:46'),
(257, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Edebey İlkokulu', '0', 'A', 'Eser KIŞLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:46'),
(258, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Edebey İlkokulu', '1', 'A', 'Eser KIŞLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:46'),
(259, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Edebey İlkokulu', '2', 'A', 'Eser KIŞLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:46'),
(260, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Edebey İlkokulu', '3', 'A', 'Eser KIŞLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:46'),
(261, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Edebey İlkokulu', '4', 'A', 'Eser KIŞLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:47'),
(262, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '5', 'A', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:47'),
(263, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '5', 'B', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:47'),
(264, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '5', 'C', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:47'),
(265, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '5', 'D', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:47'),
(266, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '5', 'E', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:47'),
(267, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '5', 'F', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:48'),
(268, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '5', 'G', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:48'),
(269, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '5', 'H', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:48'),
(270, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '5', 'I', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:48'),
(271, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '5', 'J', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:48'),
(272, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '6', 'A', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:49'),
(273, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '6', 'B', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:49'),
(274, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '6', 'C', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:49'),
(275, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '6', 'D', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:49'),
(276, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '6', 'E', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:49'),
(277, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '6', 'F', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:49'),
(278, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '6', 'G', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:50'),
(279, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '6', 'H', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:50'),
(280, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '6', 'I', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:50'),
(281, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '6', 'J', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:50'),
(282, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '7', 'A', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:50'),
(283, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '7', 'B', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:50'),
(284, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '7', 'C', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:51'),
(285, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '7', 'D', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:51'),
(286, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '7', 'E', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:51'),
(287, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '8', 'A', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:51'),
(288, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '8', 'B', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:51'),
(289, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '8', 'C', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:52'),
(290, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '8', 'D', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:52'),
(291, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Erdem Beyazıt İmam Hatip Ortaokulu', '8', 'E', 'Mehmet Akif BAKİLER', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 18:59:52'),
(292, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi İmam Hatip Ortaokulu', '0', 'A', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:52'),
(293, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi İmam Hatip Ortaokulu', '0', 'B', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:52'),
(294, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi İmam Hatip Ortaokulu', '5', 'A', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:52'),
(295, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi İmam Hatip Ortaokulu', '5', 'B', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:53'),
(296, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi İmam Hatip Ortaokulu', '6', 'A', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:53'),
(297, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi İmam Hatip Ortaokulu', '6', 'B', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:53'),
(298, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi İmam Hatip Ortaokulu', '7', 'A', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:53'),
(299, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi İmam Hatip Ortaokulu', '7', 'B', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:53'),
(300, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi İmam Hatip Ortaokulu', '8', 'A', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:54'),
(301, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi İmam Hatip Ortaokulu', '8', 'B', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 18:59:54'),
(302, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '5', 'A', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:54'),
(303, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '5', 'B', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:54'),
(304, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '5', 'C', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:54'),
(305, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '5', 'D', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:54'),
(306, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '5', 'E', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:55'),
(307, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '6', 'A', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:55'),
(308, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '6', 'B', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:55'),
(309, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '6', 'C', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:55'),
(310, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '6', 'D', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:55'),
(311, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '6', 'E', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:55'),
(312, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '7', 'A', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:56'),
(313, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '7', 'B', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:56'),
(314, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '7', 'C', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:56'),
(315, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '7', 'D', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:56'),
(316, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '8', 'A', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:56'),
(317, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '8', 'B', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:57'),
(318, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '8', 'C', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:57'),
(319, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ertuğrulgazi Ortaokulu', '8', 'D', 'Cafer YOZGAT', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 18:59:57'),
(320, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Fikriye Koşarer Anaokulu', '0', '….', 'Semiha ÖZCAN', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:57'),
(321, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Fikriye Koşarer Anaokulu', '0', '….', 'Semiha ÖZCAN', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:57'),
(322, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Fikriye Koşarer Anaokulu', '0', '….', 'Semiha ÖZCAN', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:58'),
(323, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Fikriye Koşarer Anaokulu', '0', '….', 'Semiha ÖZCAN', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:58'),
(324, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Fikriye Koşarer Anaokulu', '0', '….', 'Semiha ÖZCAN', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:58'),
(325, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Fikriye Koşarer Anaokulu', '0', '….', 'Semiha ÖZCAN', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:58'),
(326, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Fikriye Koşarer Anaokulu', '0', '….', 'Semiha ÖZCAN', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:59'),
(327, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Fikriye Koşarer Anaokulu', '0', '….', 'Semiha ÖZCAN', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:59'),
(328, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Fikriye Koşarer Anaokulu', '0', '….', 'Semiha ÖZCAN', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:59'),
(329, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Fikriye Koşarer Anaokulu', '0', '….', 'Semiha ÖZCAN', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:59'),
(330, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Fikriye Koşarer Anaokulu', '0', '….', 'Semiha ÖZCAN', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 18:59:59'),
(331, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Fikriye Koşarer Anaokulu', '0', '….', 'Semiha ÖZCAN', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:00'),
(332, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Hacı Sevim Yıldız Anaokulu', '0', 'A', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:00'),
(333, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Hacı Sevim Yıldız Anaokulu', '0', 'B', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:00'),
(334, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Hacı Sevim Yıldız Anaokulu', '0', 'C', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:00'),
(335, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Hacı Sevim Yıldız Anaokulu', '0', 'D', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:01'),
(336, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Hamzabey İlkokulu ', '0', 'A', 'Yılmaz  BAYRAKTAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:01'),
(337, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Hamzabey İlkokulu ', '1', 'A', 'Yılmaz  BAYRAKTAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:01'),
(338, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Hamzabey İlkokulu ', '2', 'A', 'Yılmaz  BAYRAKTAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:01'),
(339, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Hamzabey İlkokulu ', '3', 'A', 'Yılmaz  BAYRAKTAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:02'),
(340, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Hamzabey İlkokulu ', '4', 'A', 'Yılmaz  BAYRAKTAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:02'),
(341, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Hamzabey Ortaokulu', '5', 'A', 'Yılmaz  BAYRAKTAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:02'),
(342, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Hamzabey Ortaokulu', '6', 'A', 'Yılmaz  BAYRAKTAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:02'),
(343, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Hamzabey Ortaokulu', '7', 'A', 'Yılmaz  BAYRAKTAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:03'),
(344, '2022-2023', 'Özel Eğitim Sınıfı .', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Hamzabey Ortaokulu', '8', '….', 'Yılmaz  BAYRAKTAR', 'Okul Müdürü', '', '', 'ÖZEL EGİTİM', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:03'),
(345, '2022-2023', 'Özel Eğitim Sınıfı ..', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Hamzabey Ortaokulu', '8', '….', 'Yılmaz  BAYRAKTAR', 'Okul Müdürü', '', '', 'ÖZEL EGİTİM', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:03'),
(346, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Hamzabey Ortaokulu', '8', 'A', 'Yılmaz  BAYRAKTAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:03'),
(347, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '1', 'A', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:03'),
(348, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '1', 'B', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:04'),
(349, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '1', 'C', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:04'),
(350, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '1', 'D', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:04'),
(351, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '2', 'A', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:04'),
(352, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '2', 'B', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:05'),
(353, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '2', 'C', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:05'),
(354, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '2', 'D', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:05'),
(355, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '3', 'A', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:05'),
(356, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '3', 'B', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:06'),
(357, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '3', 'C', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:06'),
(358, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '3', 'D', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:06'),
(359, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '4', 'A', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:06'),
(360, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '4', 'B', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:07'),
(361, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '4', 'C', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:07'),
(362, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İnegöl İlkokulu', '4', 'D', 'Fatih BOYSAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:07'),
(363, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İsaören  Ortaokulu', '5', 'A', 'Nazım ADAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:07'),
(364, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İsaören  Ortaokulu', '6', 'A', 'Nazım ADAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:08'),
(365, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İsaören  Ortaokulu', '7', 'A', 'Nazım ADAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:08'),
(366, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İsaören  Ortaokulu', '8', 'A', 'Nazım ADAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:08'),
(367, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İsaören İlkokulu', '0', 'A', 'Nazım ADAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:08'),
(368, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İsaören İlkokulu', '1', 'A', 'Nazım ADAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:08'),
(369, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İsaören İlkokulu', '2', 'A', 'Nazım ADAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:09'),
(370, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İsaören İlkokulu', '3', 'A', 'Nazım ADAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:09'),
(371, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İsaören İlkokulu', '4', 'A', 'Nazım ADAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:09'),
(372, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İshakpaşa Anaokulu', '0', '….', 'Musa TAÇYILDIZ', 'Okul Müdürü', '', '', 'ŞUBESİZ ', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:09'),
(373, '2022-2023', '3-Sabahçı .', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İshakpaşa Anaokulu', '0', 'A', 'Musa TAÇYILDIZ', 'Okul Müdürü', '', '', 'SABAHÇI', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:10'),
(374, '2022-2023', '3-Sabahçı .', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İshakpaşa Anaokulu', '0', 'B', 'Musa TAÇYILDIZ', 'Okul Müdürü', '', '', 'SABAHÇI', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:10'),
(375, '2022-2023', '4-Öğlenci .', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İshakpaşa Anaokulu', '0', 'A', 'Musa TAÇYILDIZ', 'Okul Müdürü', '', '', 'ÖĞRLENCİ', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:10'),
(376, '2022-2023', '4-Öğlenci .', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İshakpaşa Anaokulu', '0', 'B', 'Musa TAÇYILDIZ', 'Okul Müdürü', '', '', 'ÖĞRLENCİ', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:10'),
(377, '2022-2023', '4-Sabahçı .', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İshakpaşa Anaokulu', '0', 'A', 'Musa TAÇYILDIZ', 'Okul Müdürü', '', '', 'SABAHÇI', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:11'),
(378, '2022-2023', '5-Sabahçı .', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İshakpaşa Anaokulu', '0', 'A', 'Musa TAÇYILDIZ', 'Okul Müdürü', '', '', 'SABAHÇI', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:11'),
(379, '2022-2023', '5-Öğlenci .', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İshakpaşa Anaokulu', '0', 'B', 'Musa TAÇYILDIZ', 'Okul Müdürü', '', '', 'ÖĞRLENCİ', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:11'),
(380, '2022-2023', '5-Öğlenci .', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İshakpaşa Anaokulu', '0', 'C', 'Musa TAÇYILDIZ', 'Okul Müdürü', '', '', 'ÖĞRLENCİ', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:11'),
(381, '2022-2023', '5-Öğlenci .', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İshakpaşa Anaokulu', '0', 'D', 'Musa TAÇYILDIZ', 'Okul Müdürü', '', '', 'ÖĞRLENCİ', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:12'),
(382, '2022-2023', '5-Öğlenci .', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İshakpaşa Anaokulu', '0', 'E', 'Musa TAÇYILDIZ', 'Okul Müdürü', '', '', 'ÖĞRLENCİ', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:12'),
(383, '2022-2023', 'Özel Eğitim Sınıfı .', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İshakpaşa Anaokulu', '0', 'A', 'Musa TAÇYILDIZ', 'Okul Müdürü', '', '', 'ÖZEL EGİTİM', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:12'),
(384, '2022-2023', 'Özel Eğitim Sınıfı .', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İshakpaşa Anaokulu', '0', 'B', 'Musa TAÇYILDIZ', 'Okul Müdürü', '', '', 'ÖZEL EGİTİM', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:12'),
(385, '2022-2023', 'Özel Eğitim Sınıfı .', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İshakpaşa Anaokulu', '0', 'C', 'Musa TAÇYILDIZ', 'Okul Müdürü', '', '', 'ÖZEL EGİTİM', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:13'),
(386, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '0', 'A', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:13'),
(387, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '0', 'B', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:13'),
(388, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '0', 'C', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:13'),
(389, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '0', 'D', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:14'),
(390, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '5', 'A', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:14'),
(391, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '5', 'B', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:14'),
(392, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '5', 'C', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:14'),
(393, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '5', 'D', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:15'),
(394, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '5', 'E', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:15'),
(395, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '5', 'F', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:15'),
(396, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '5', 'G', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:15'),
(397, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '6', 'A', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:15'),
(398, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '6', 'B', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:15'),
(399, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '6', 'C', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:16'),
(400, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '6', 'D', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:16'),
(401, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '6', 'E', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:16'),
(402, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '6', 'F', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:16'),
(403, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '6', 'G', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:16'),
(404, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '6', 'I', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:16'),
(405, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '7', 'A', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:17'),
(406, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '7', 'B', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:17'),
(407, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '7', 'C', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:17'),
(408, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '7', 'D', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:17'),
(409, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '7', 'E', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:17'),
(410, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '7', 'F', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:18'),
(411, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '7', 'G', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:18'),
(412, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '8', 'A', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:18'),
(413, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '8', 'B', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:18'),
(414, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '8', 'C', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:18'),
(415, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '8', 'D', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:18'),
(416, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '8', 'E', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:19'),
(417, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İstaş Kentaş Ortaokulu', '8', 'F', 'Murat Semih EVREN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:19'),
(418, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '1', 'A', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:19'),
(419, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '1', 'B', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:19'),
(420, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '1', 'C', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:20'),
(421, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '1', 'D', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:20');
INSERT INTO `tlp_ogretmenbilgileri_tbl` (`oid`, `yili`, `adisoyadi`, `brans`, `il`, `ilce`, `kurumkodu`, `okuladi`, `sinif`, `sube`, `muduradi`, `mudurunvani`, `cep`, `eposta`, `adres`, `aciklama`, `bayi`, `logoadi`, `kayittarihi`) VALUES
(422, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '1', 'E', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:20'),
(423, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '1', 'F', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:20'),
(424, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '1', 'G', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:21'),
(425, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '1', 'H', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:21'),
(426, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '1', 'I', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:21'),
(427, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '1', 'İ', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:21'),
(428, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '2', 'A', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:22'),
(429, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '2', 'B', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:22'),
(430, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '2', 'C', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:22'),
(431, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '2', 'D', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:23'),
(432, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '2', 'E', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:23'),
(433, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '2', 'F', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:23'),
(434, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '2', 'G', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:23'),
(435, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '2', 'H', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:24'),
(436, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '2', 'I', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:24'),
(437, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '2', 'İ', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:24'),
(438, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '3', 'A', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:24'),
(439, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '3', 'B', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:25'),
(440, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '3', 'C', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:25'),
(441, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '3', 'D', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:25'),
(442, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '3', 'E', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:26'),
(443, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '3', 'F', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:26'),
(444, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '3', 'G', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:26'),
(445, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '3', 'H', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:26'),
(446, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '3', 'I', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:27'),
(447, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '4', 'A', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:27'),
(448, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '4', 'B', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:27'),
(449, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '4', 'C', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:27'),
(450, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '4', 'D', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:28'),
(451, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '4', 'E', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:28'),
(452, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '4', 'F', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:28'),
(453, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '4', 'G', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:29'),
(454, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '4', 'H', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:29'),
(455, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '4', 'I', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:29'),
(456, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe İlkokulu', '4', 'İ', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:29'),
(457, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '5', 'A', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:30'),
(458, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '5', 'B', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:30'),
(459, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '5', 'C', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:30'),
(460, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '5', 'D', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:30'),
(461, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '5', 'E', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:30'),
(462, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '5', 'F', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:31'),
(463, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '5', 'G', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:31'),
(464, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '5', 'H', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:31'),
(465, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '5', 'I', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:31'),
(466, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '5', 'İ', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:31'),
(467, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '6', 'A', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:31'),
(468, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '6', 'B', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:32'),
(469, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '6', 'C', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:32'),
(470, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '6', 'D', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:32'),
(471, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '6', 'E', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:32'),
(472, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '6', 'F', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:32'),
(473, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '6', 'G', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:33'),
(474, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '6', 'H', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:33'),
(475, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '6', 'I', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:33'),
(476, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '6', 'İ', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:33'),
(477, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '6', 'J', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:33'),
(478, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '7', 'A', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:33'),
(479, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '7', 'B', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:34'),
(480, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '7', 'C', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:34'),
(481, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '7', 'D', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:34'),
(482, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '7', 'E', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:34'),
(483, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '7', 'F', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:34'),
(484, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '7', 'G', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:35'),
(485, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '7', 'H', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:35'),
(486, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '7', 'I', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:35'),
(487, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '7', 'İ', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:35'),
(488, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '8', 'A', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:35'),
(489, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '8', 'B', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:36'),
(490, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '8', 'C', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:36'),
(491, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '8', 'D', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:36'),
(492, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '8', 'E', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:36'),
(493, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '8', 'F', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:36'),
(494, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '8', 'G', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:36'),
(495, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '8', 'H', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:37'),
(496, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '8', 'I', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:37'),
(497, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Kocatepe Ortaokulu', '8', 'İ', 'Mahsuni CANBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamasız', '388', '', '2022-05-04 19:00:37'),
(498, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Küçükyenice İlkokulu', '0', 'A', 'Ensar ÖZCAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:37'),
(499, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Küçükyenice İlkokulu', '1', 'A', 'Ensar ÖZCAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:37'),
(500, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Küçükyenice İlkokulu', '2', 'A', 'Ensar ÖZCAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:38'),
(501, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Küçükyenice İlkokulu', '3', 'A', 'Ensar ÖZCAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:38'),
(502, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Küçükyenice İlkokulu', '4', 'A', 'Ensar ÖZCAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:00:38'),
(503, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Küçükyenice Ortaokulu', '5', 'A', 'Ensar ÖZCAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:39'),
(504, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Küçükyenice Ortaokulu', '6', 'A', 'Ensar ÖZCAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:39'),
(505, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Küçükyenice Ortaokulu', '7', 'A', 'Ensar ÖZCAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:39'),
(506, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Küçükyenice Ortaokulu', '8', 'A', 'Ensar ÖZCAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:39'),
(507, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '5', 'A', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:39'),
(508, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '5', 'B', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:39'),
(509, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '5', 'C', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:40'),
(510, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '5', 'D', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:40'),
(511, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '6', 'A', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:40'),
(512, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '6', 'B', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:40'),
(513, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '6', 'C', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:40'),
(514, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '6', 'D', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:41'),
(515, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '6', 'E', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', 'NÖBET DEFTERİ', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:41'),
(516, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '7', 'A', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:41'),
(517, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '7', 'B', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:41'),
(518, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '7', 'C', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:41'),
(519, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '7', 'D', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:42'),
(520, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '8', 'A', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:42'),
(521, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '8', 'B', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:42'),
(522, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '8', 'C', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:42'),
(523, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Müşerref - Muzaffer Samda Ortaokulu', '8', 'D', 'Fehmi KABATAŞ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:42'),
(524, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '9', 'A', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:42'),
(525, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '9', 'B', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:43'),
(526, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '9', 'C', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:43'),
(527, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '9', 'D', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:43'),
(528, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '10', 'A', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:43'),
(529, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '10', 'B', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:43'),
(530, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '10', 'C', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:43'),
(531, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '10', 'D', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:44'),
(532, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '10', 'E', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:44'),
(533, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '10', 'F', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:44'),
(534, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '11', 'A', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:44'),
(535, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '11', 'B', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:44'),
(536, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '11', 'C', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:45'),
(537, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '11', 'D', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:45'),
(538, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '11', 'E', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:45'),
(539, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '11', 'F', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:45'),
(540, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '11', 'G', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:45'),
(541, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '11', 'H', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:46'),
(542, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '11', 'I', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:46'),
(543, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '12', 'A', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:46'),
(544, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '12', 'B', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:46'),
(545, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '12', 'C', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:46'),
(546, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '12', 'D', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:46'),
(547, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '12', 'E', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:47'),
(548, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '12', 'F', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:47'),
(549, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '12', 'G', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:47'),
(550, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '12', 'H', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:47'),
(551, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Naire Çikayeva Anadolu Lisesi', '12', 'I', 'Mevlüt KOKMAZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:47'),
(552, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ömer Osman Çağlayan Ortaokulu', '5', 'A', 'Davut ÜNGÖR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:48'),
(553, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ömer Osman Çağlayan Ortaokulu', '5', 'B', 'Davut ÜNGÖR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:48'),
(554, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ömer Osman Çağlayan Ortaokulu', '6', 'A', 'Davut ÜNGÖR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:48'),
(555, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ömer Osman Çağlayan Ortaokulu', '6', 'B', 'Davut ÜNGÖR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:48'),
(556, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ömer Osman Çağlayan Ortaokulu', '6', 'C', 'Davut ÜNGÖR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:48'),
(557, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ömer Osman Çağlayan Ortaokulu', '7', 'A', 'Davut ÜNGÖR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:49'),
(558, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ömer Osman Çağlayan Ortaokulu', '7', 'B', 'Davut ÜNGÖR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:49'),
(559, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ömer Osman Çağlayan Ortaokulu', '8', 'A', 'Davut ÜNGÖR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:49'),
(560, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ömer Osman Çağlayan Ortaokulu', '8', 'B', 'Davut ÜNGÖR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:00:49'),
(561, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil Anadolu Lisesi', '9', 'A', 'Mesut MUTLU', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:49'),
(562, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil Anadolu Lisesi', '9', 'B', 'Mesut MUTLU', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:49'),
(563, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil Anadolu Lisesi', '10', 'A', 'Mesut MUTLU', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:50'),
(564, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil Anadolu Lisesi', '10', 'B', 'Mesut MUTLU', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:50'),
(565, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil Anadolu Lisesi', '11', 'A', 'Mesut MUTLU', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:50'),
(566, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil Anadolu Lisesi', '11', 'B', 'Mesut MUTLU', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:50'),
(567, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil Anadolu Lisesi', '12', 'A', 'Mesut MUTLU', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:50'),
(568, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil Anadolu Lisesi', '12', 'B', 'Mesut MUTLU', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:51'),
(569, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ANAOKULU', '0', 'A', 'Sedar ACAR', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:51'),
(570, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ANAOKULU', '0', 'B', 'Sedar ACAR', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:51'),
(571, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ANAOKULU', '0', 'C', 'Sedar ACAR', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:51'),
(572, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ANAOKULU', '0', 'D', 'Sedar ACAR', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:51'),
(573, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ANAOKULU', '0', 'E', 'Sedar ACAR', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:51'),
(574, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil Fen Lisesi', '9', 'A', 'Mesut MUTLU', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:52'),
(575, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil Fen Lisesi', '10', 'A', 'Mesut MUTLU', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:52'),
(576, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil Fen Lisesi', '10', 'B', 'Mesut MUTLU', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:52'),
(577, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil Fen Lisesi', '11', 'A', 'Mesut MUTLU', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:52'),
(578, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil Fen Lisesi', '12', '….', 'Mesut MUTLU', 'Okul Müdürü', '', '', 'YEDEK', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:52'),
(579, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil Fen Lisesi', '12', 'A', 'Mesut MUTLU', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:53'),
(580, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil İlkokulu', '1', 'A', 'Sedar ACAR', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:53'),
(581, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil İlkokulu', '1', 'B', 'Sedar ACAR', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:53'),
(582, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil İlkokulu', '1', 'C', 'Sedar ACAR', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:53'),
(583, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil İlkokulu', '2', 'A', 'Sedar ACAR', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:53'),
(584, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil İlkokulu', '2', 'B', 'Sedar ACAR', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:53'),
(585, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil İlkokulu', '2', 'C', 'Sedar ACAR', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:54'),
(586, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil İlkokulu', '3', 'A', 'Sedar ACAR', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:54'),
(587, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil İlkokulu', '3', 'B', 'Sedar ACAR', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:54'),
(588, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil İlkokulu', '3', 'C', 'Sedar ACAR', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:54'),
(589, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil İlkokulu', '4', 'A', 'Sedar ACAR', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:54'),
(590, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil İlkokulu', '4', 'B', 'Sedar ACAR', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:55'),
(591, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Özel Altın Nesil İlkokulu', '4', 'C', 'Sedar ACAR', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:55'),
(592, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ORTAOKULU', '5', 'A', 'Sedar ACAR', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:55'),
(593, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ORTAOKULU', '5', 'B', 'Sedar ACAR', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:55'),
(594, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ORTAOKULU', '5', 'C', 'Sedar ACAR', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:55'),
(595, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ORTAOKULU', '5', 'D', 'Sedar ACAR', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:56'),
(596, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ORTAOKULU', '6', 'A', 'Sedar ACAR', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:56'),
(597, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ORTAOKULU', '6', 'B', 'Sedar ACAR', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:56'),
(598, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ORTAOKULU', '6', 'C', 'Sedar ACAR', 'Okul Müdürü', '', '', 'MAVİ ', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:56'),
(599, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ORTAOKULU', '7', 'A', 'Sedar ACAR', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:56'),
(600, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ORTAOKULU', '7', 'B', 'Sedar ACAR', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:57'),
(601, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ORTAOKULU', '7', 'C', 'Sedar ACAR', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:57'),
(602, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ORTAOKULU', '7', 'D', 'Sedar ACAR', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:57'),
(603, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ORTAOKULU', '8', 'A', 'Sedar ACAR', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:57'),
(604, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ORTAOKULU', '8', 'B', 'Sedar ACAR', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:57'),
(605, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji anadolu lisesi', '9', 'A', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:57'),
(606, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji anadolu lisesi', '9', 'B', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:58'),
(607, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji anadolu lisesi', '10', 'A', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:58'),
(608, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji anadolu lisesi', '10', 'B', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:58'),
(609, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji anadolu lisesi', '11', 'A', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:58'),
(610, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji anadolu lisesi', '11', 'B', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:58'),
(611, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji anadolu lisesi', '12', 'A', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:59'),
(612, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji anadolu lisesi', '12', 'B', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:59'),
(613, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji fenlisesi', '9', 'A', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:59'),
(614, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji fenlisesi', '10', 'A', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:59'),
(615, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji fenlisesi', '11', 'A', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:59'),
(616, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji fenlisesi', '12', 'A', '………. ……….', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:00:59'),
(617, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ilkokulu', '1', 'A', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:00'),
(618, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ilkokulu', '1', 'B', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:00'),
(619, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ilkokulu', '2', 'A', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:00'),
(620, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ilkokulu', '2', 'B ', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:00'),
(621, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ilkokulu', '3', 'A', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:00'),
(622, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ilkokulu', '4', 'A', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:01'),
(623, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ilkokulu', '4', 'B', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:01'),
(624, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ortokulu', '5', 'A', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:01'),
(625, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ortokulu', '5', 'B', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:01'),
(626, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ortokulu', '6', 'A', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:01'),
(627, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ortokulu', '6', 'B', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:02'),
(628, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ortokulu', '7', 'A', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:02'),
(629, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ortokulu', '7', 'B', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:02'),
(630, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ortokulu', '8', 'A', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:02'),
(631, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ortokulu', '8', 'B', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:02'),
(632, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'özel Okyanus koleji ortokulu', '8', 'C', 'Emin ERBAY', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:03'),
(633, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '5', 'A', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:03');
INSERT INTO `tlp_ogretmenbilgileri_tbl` (`oid`, `yili`, `adisoyadi`, `brans`, `il`, `ilce`, `kurumkodu`, `okuladi`, `sinif`, `sube`, `muduradi`, `mudurunvani`, `cep`, `eposta`, `adres`, `aciklama`, `bayi`, `logoadi`, `kayittarihi`) VALUES
(634, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '5', 'B', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:03'),
(635, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '6', 'A', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:03'),
(636, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '7', 'A', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:03'),
(637, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '8', 'A', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:03'),
(638, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '8', 'B', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:04'),
(639, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '9', 'A', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:04'),
(640, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '9', 'B', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:04'),
(641, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '10', 'A', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:04'),
(642, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '10', 'B', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:04'),
(643, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '11', 'A', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:05'),
(644, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '11', 'B', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:05'),
(645, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '11', 'C', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:05'),
(646, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '12', 'A', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:05'),
(647, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '12', 'B', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:05'),
(648, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'SELANİK KOLEJİ', '12', 'C', 'Özdemir VAROL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:05'),
(649, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '5', 'A', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:06'),
(650, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '5', 'B', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:06'),
(651, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '5', 'C', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:06'),
(652, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '5', 'D', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:06'),
(653, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '5', 'E', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:06'),
(654, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '5', 'F', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:07'),
(655, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '6', 'A', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:07'),
(656, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '6', 'B', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:07'),
(657, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '6', 'C', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:07'),
(658, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '6', 'D', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:07'),
(659, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '6', 'E', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:08'),
(660, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '6', 'F', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', 'NÖBET DEFTERİ', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:08'),
(661, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '7', 'A', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', 'TAMGÜN', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:08'),
(662, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '7', 'B', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:08'),
(663, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '7', 'C', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:08'),
(664, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '7', 'D', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:08'),
(665, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '7', 'E', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:09'),
(666, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '7', 'F', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:09'),
(667, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '8', 'A', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:09'),
(668, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '8', 'B', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:09'),
(669, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '8', 'C', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:09'),
(670, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '8', 'D', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:10'),
(671, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '8', 'E', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:10'),
(672, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '9', 'A', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:10'),
(673, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '9', 'B', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:10'),
(674, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '9', 'C', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:10'),
(675, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '9', 'D', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:10'),
(676, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '10', 'A', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:11'),
(677, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '10', 'B', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:11'),
(678, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '10', 'C', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:11'),
(679, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '10', 'D', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:11'),
(680, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '11', 'A', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:11'),
(681, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '11', 'B', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:12'),
(682, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '11', 'C', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:12'),
(683, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '11', 'D', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:12'),
(684, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '12', 'A', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:12'),
(685, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '12', 'B', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:12'),
(686, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '12', 'C', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:13'),
(687, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Spor Lisesi', '12', 'D', 'Orhan ATAN', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamasız', '388', '', '2022-05-04 19:01:13'),
(688, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '0', 'A', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:13'),
(689, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '0', 'B', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:13'),
(690, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '0', 'C', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:14'),
(691, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '1', 'A', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:14'),
(692, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '1', 'B', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:14'),
(693, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '1', 'C', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:14'),
(694, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '1', 'D', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:15'),
(695, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '1', 'E', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:15'),
(696, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '1', 'F', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:15'),
(697, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '2', 'A', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:16'),
(698, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '2', 'B', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:16'),
(699, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '2', 'C', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:16'),
(700, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '2', 'D', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:17'),
(701, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '2', 'E', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:17'),
(702, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '2', 'F', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:17'),
(703, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '3', 'A', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:18'),
(704, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '3', 'B', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:18'),
(705, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '3', 'C', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:18'),
(706, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '3', 'D', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:18'),
(707, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '3', 'E', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:19'),
(708, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '3', 'F', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:19'),
(709, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '4', '….', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:19'),
(710, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '4', '….', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:20'),
(711, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '4', 'A', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:20'),
(712, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '4', 'B', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:20'),
(713, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '4', 'C', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:21'),
(714, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '4', 'D', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:21'),
(715, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '4', 'E', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:21'),
(716, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Mehmet Akif Ersoy İlkokulu', '4', 'F', 'Fikret KILIÇ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:22'),
(717, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ necip fazıl kısakürek imam hatip ortaokulu', '5', 'A', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:22'),
(718, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ necip fazıl kısakürek imam hatip ortaokulu', '5', 'B', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:22'),
(719, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ necip fazıl kısakürek imam hatip ortaokulu', '6', 'A', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:22'),
(720, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ necip fazıl kısakürek imam hatip ortaokulu', '6', 'B', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:22'),
(721, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ necip fazıl kısakürek imam hatip ortaokulu', '7', 'A', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:23'),
(722, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ necip fazıl kısakürek imam hatip ortaokulu', '7', 'B', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:23'),
(723, '2022-2023', 'Özel Eğitim Sınıfı .', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ necip fazıl kısakürek imam hatip ortaokulu', '8', '….', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:23'),
(724, '2022-2023', 'Özel Eğitim Sınıfı .', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ necip fazıl kısakürek imam hatip ortaokulu', '8', '….', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:23'),
(725, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ necip fazıl kısakürek imam hatip ortaokulu', '8', 'A', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:23'),
(726, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '5', 'A', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:24'),
(727, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '5', 'B', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:24'),
(728, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '5', 'C', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:24'),
(729, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '5', 'D', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:24'),
(730, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '5', 'E', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'YEŞİL', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:24'),
(731, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '6', 'A', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:24'),
(732, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '6', 'B', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:25'),
(733, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '6', 'C', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:25'),
(734, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '6', 'D', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:25'),
(735, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '6', 'E', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'LACİVERT', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:25'),
(736, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '7', 'A', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:25'),
(737, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '7', 'B', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:26'),
(738, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '7', 'C', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:26'),
(739, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '7', 'D', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:26'),
(740, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '7', 'E', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:26'),
(741, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '8', 'A', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:26'),
(742, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '8', 'B', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:27'),
(743, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '8', 'C', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:27'),
(744, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '8', 'D', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:27'),
(745, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'T O K İ Necip Fazıl Kısakürek Ortaokulu', '8', 'E', 'Talip YEDİYİLDİZ', 'Okul Müdürü', '', '', 'SİYAH', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:27'),
(746, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '0', 'A', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:27'),
(747, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '0', 'B', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:28'),
(748, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '0', 'C', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:28'),
(749, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '0', 'D', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:28'),
(750, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '1', 'A', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:28'),
(751, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '1', 'B', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:29'),
(752, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '1', 'C', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:29'),
(753, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '1', 'D', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:29'),
(754, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '1', 'E', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:30'),
(755, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '2', 'A', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:30'),
(756, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '2', 'B', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:30'),
(757, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '2', 'C', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:31'),
(758, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '2', 'D', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:31'),
(759, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '2', 'E', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:31'),
(760, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '3', 'A', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:32'),
(761, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '3', 'B', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:32'),
(762, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '3', 'C', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:32'),
(763, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '3', 'D', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:33'),
(764, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '3', 'E', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:33'),
(765, '2022-2023', 'Destek Eğitim Sınıfı .', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '4', '….', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:33'),
(766, '2022-2023', 'Dinkültürü Ders Defteri .', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '4', '….', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:34'),
(767, '2022-2023', 'İngilizce Ders Defteri .', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '4', '….', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:34'),
(768, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '4', 'A', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:34'),
(769, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '4', 'B', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:34'),
(770, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '4', 'C', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:35'),
(771, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '4', 'D', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:35'),
(772, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '4', 'E', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:36'),
(773, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '0', 'A', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:36'),
(774, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '0', 'B', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:36'),
(775, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '0', 'C', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:36'),
(776, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '0', 'D', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:37'),
(777, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '1', 'A', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:37'),
(778, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '1', 'B', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:37'),
(779, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '1', 'C', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:38'),
(780, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '1', 'D', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:38'),
(781, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '2', 'A', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:38'),
(782, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '2', 'B', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:39'),
(783, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '2', 'C', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:39'),
(784, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '2', 'D', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:39'),
(785, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '3', 'A', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:40'),
(786, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '3', 'B', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:40'),
(787, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '3', 'C', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:40'),
(788, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '3', 'D', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:41'),
(789, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '4', 'A', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:41'),
(790, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '4', 'B', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:41'),
(791, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '4', 'C', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:42'),
(792, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yenice Ali Şefika Göztepe İlkokulu', '4', 'D', 'İbrahim ŞENAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 1-2-3-4 Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:42'),
(793, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '5', 'A', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:42'),
(794, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '5', 'B', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:43'),
(795, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '5', 'C', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:43'),
(796, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '5', 'D', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:43'),
(797, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '5', 'E', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:43'),
(798, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '6', 'A', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:43'),
(799, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '6', 'B', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:44'),
(800, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '6', 'C', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:44'),
(801, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '6', 'D', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:44'),
(802, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '6', 'E', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:44'),
(803, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '7', 'A', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:44'),
(804, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '7', 'B', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:44'),
(805, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '7', 'C', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:45'),
(806, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '7', 'D', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:45'),
(807, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '8', 'A', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:45'),
(808, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '8', 'B', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:45'),
(809, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '8', 'C', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:45'),
(810, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Yıldırım Bayezid İmam Hatip Ortaokulu', '8', 'D', 'Harun ÖZYOLCU', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5--12 Ders / 8 / Yoklamalı', '388', '', '2022-05-04 19:01:46'),
(811, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Zübeyde Hanım Anaokulu', '0', 'A', '………. ……….', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:46'),
(812, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Zübeyde Hanım Anaokulu', '0', 'B', '………. ……….', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:46'),
(813, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Zübeyde Hanım Anaokulu', '0', 'C', '………. ……….', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:46'),
(814, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Zübeyde Hanım Anaokulu', '0', 'D', '………. ……….', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:47'),
(815, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Zübeyde Hanım Anaokulu', '0', 'E', '………. ……….', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:47'),
(816, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Zübeyde Hanım Anaokulu', '0', 'F', '………. ……….', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:47'),
(817, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Zübeyde Hanım Anaokulu', '0', 'G', '………. ……….', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:48'),
(818, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Zübeyde Hanım Anaokulu', '0', 'H', '………. ……….', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:48'),
(819, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Zübeyde Hanım Anaokulu', '0', 'I', '………. ……….', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:48'),
(820, '2022-2023', '………. ……….', 'Okul Öncesi Öğretmeni', 'BURSA', 'İnegöl', '0', 'Zübeyde Hanım Anaokulu', '0', 'J', '………. ……….', 'Okul Müdürü', '', '', 'BORDO', 'İMPERTEKS / Ana Sınıfı Ders / 6 / Yoklamalı', '388', '', '2022-05-04 19:01:49'),
(821, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'KÜTAHYA', 'Domaniç', '0', 'DOMANİÇ ORTAOKULU', '5', 'A', 'Gökmen ÇAKMAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:49'),
(822, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'KÜTAHYA', 'Domaniç', '0', 'DOMANİÇ ORTAOKULU', '5', 'B', 'Gökmen ÇAKMAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:49'),
(823, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'KÜTAHYA', 'Domaniç', '0', 'DOMANİÇ ORTAOKULU', '5', 'C', 'Gökmen ÇAKMAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:50'),
(824, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'KÜTAHYA', 'Domaniç', '0', 'DOMANİÇ ORTAOKULU', '6', 'A', 'Gökmen ÇAKMAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:50'),
(825, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'KÜTAHYA', 'Domaniç', '0', 'DOMANİÇ ORTAOKULU', '6', 'B', 'Gökmen ÇAKMAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:50'),
(826, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'KÜTAHYA', 'Domaniç', '0', 'DOMANİÇ ORTAOKULU', '6', 'C', 'Gökmen ÇAKMAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:50'),
(827, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'KÜTAHYA', 'Domaniç', '0', 'DOMANİÇ ORTAOKULU', '7', 'A', 'Gökmen ÇAKMAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:50'),
(828, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'KÜTAHYA', 'Domaniç', '0', 'DOMANİÇ ORTAOKULU', '7', 'B', 'Gökmen ÇAKMAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:51'),
(829, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'KÜTAHYA', 'Domaniç', '0', 'DOMANİÇ ORTAOKULU', '7', 'C', 'Gökmen ÇAKMAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:51'),
(830, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'KÜTAHYA', 'Domaniç', '0', 'DOMANİÇ ORTAOKULU', '8', 'A', 'Gökmen ÇAKMAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:51'),
(831, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'KÜTAHYA', 'Domaniç', '0', 'DOMANİÇ ORTAOKULU', '8', 'B', 'Gökmen ÇAKMAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:51'),
(832, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'KÜTAHYA', 'Domaniç', '0', 'DOMANİÇ ORTAOKULU', '8', 'C', 'Gökmen ÇAKMAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / 5-6-7-8 Ders / 7 / Yoklamalı', '388', '', '2022-05-04 19:01:51'),
(833, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Sezai Karakoç Ortaokulu', '27', 'Z', 'Ahmet SAĞLAM', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Tüm Sınıflar Ders /  / Normal Eğitim', '388', '', '2022-05-04 19:01:52'),
(834, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'İsaören  Ortaokulu', '27', 'Z', 'Nazım ADAL', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Tüm Sınıflar Ders /  / Normal Eğitim', '388', '', '2022-05-04 19:01:52'),
(835, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'ÖZEL ALTIN NESİL ORTAOKULU', '28', 'Z', 'Sedar ACAR', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Tüm Sınıflar Ders /  / Normal Eğitim', '388', '', '2022-05-04 19:01:52'),
(836, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Dr. Emin Acar Imam hatip ortaokulu', '28', 'Z', 'Yusuf Ziya ÇOLAK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Tüm Sınıflar Ders /  / Normal Eğitim', '388', '', '2022-05-04 19:01:52'),
(837, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Ticaret ve Sanayi Odası İlkokulu', '46', 'Z', 'Kadir FİLİZ', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Tüm Sınıflar Ders /  / İkili Eğitim', '388', '', '2022-05-04 19:01:53'),
(838, '2022-2023', '………. ……….', 'Sınıf Öğretmeni', 'BURSA', 'İnegöl', '0', 'Abdulhamit Han Ortaokulu', '47', 'Z', 'İnan BİRLİK', 'Okul Müdürü', '', '', '', 'İMPERTEKS / Tüm Sınıflar Ders /  / İkili Eğitim', '388', '', '2022-05-04 19:01:53');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tlp_sosyalkulup_tbl`
--

CREATE TABLE `tlp_sosyalkulup_tbl` (
  `id` int(11) NOT NULL,
  `oid` int(11) NOT NULL,
  `kulupkodu` int(8) NOT NULL,
  `ikinciogretmen` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  `fiyat` double NOT NULL,
  `taleptarihi` datetime NOT NULL,
  `basimtarihi` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tlp_y_anadersler_tbl`
--

CREATE TABLE `tlp_y_anadersler_tbl` (
  `id` int(11) NOT NULL,
  `oid` int(11) NOT NULL,
  `dersid` int(8) NOT NULL,
  `fiyat` double NOT NULL,
  `taleptarihi` datetime NOT NULL,
  `basimtarihi` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tlp_y_serbestler_tbl`
--

CREATE TABLE `tlp_y_serbestler_tbl` (
  `id` int(11) NOT NULL,
  `oid` int(11) NOT NULL,
  `dersid` int(8) NOT NULL,
  `saat` smallint(2) NOT NULL DEFAULT '1',
  `taleptarihi` datetime NOT NULL,
  `basimtarihi` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tlp_zumreogretmenleri_tbl`
--

CREATE TABLE `tlp_zumreogretmenleri_tbl` (
  `id` int(11) NOT NULL,
  `oid` int(11) NOT NULL,
  `ogretmenadi` varchar(64) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `odemeler_tbl`
--
ALTER TABLE `odemeler_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_anadersleroto_tbl`
--
ALTER TABLE `sis_anadersleroto_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_bayiler_tbl`
--
ALTER TABLE `sis_bayiler_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_branslar_tbl`
--
ALTER TABLE `sis_branslar_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_defterler_tbl`
--
ALTER TABLE `sis_defterler_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_dersdagilim_gruplari`
--
ALTER TABLE `sis_dersdagilim_gruplari`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_ekurunler_tbl`
--
ALTER TABLE `sis_ekurunler_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_excel_bilgisutunlari_tbl`
--
ALTER TABLE `sis_excel_bilgisutunlari_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_gunlukplandersler_tbl`
--
ALTER TABLE `sis_gunlukplandersler_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_ildersleri_tbl`
--
ALTER TABLE `sis_ildersleri_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_iller_tbl`
--
ALTER TABLE `sis_iller_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_ilyayinevino_tbl`
--
ALTER TABLE `sis_ilyayinevino_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_kurtulus_tbl`
--
ALTER TABLE `sis_kurtulus_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_mudurunvan_tbl`
--
ALTER TABLE `sis_mudurunvan_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_nobetyerisablon_tbl`
--
ALTER TABLE `sis_nobetyerisablon_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_odemeturu_tbl`
--
ALTER TABLE `sis_odemeturu_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_serbestetkinlikderssaati_tbl`
--
ALTER TABLE `sis_serbestetkinlikderssaati_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_serbestetkinlikler_tbl`
--
ALTER TABLE `sis_serbestetkinlikler_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_siniflar_tbl`
--
ALTER TABLE `sis_siniflar_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_sosyalkulupler_tbl`
--
ALTER TABLE `sis_sosyalkulupler_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_tumdersler_tbl`
--
ALTER TABLE `sis_tumdersler_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_varsayilanlar_tbl`
--
ALTER TABLE `sis_varsayilanlar_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sis_yillar_tbl`
--
ALTER TABLE `sis_yillar_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tlp_defterler_tbl`
--
ALTER TABLE `tlp_defterler_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tlp_ekurunler_tbl`
--
ALTER TABLE `tlp_ekurunler_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tlp_g_anadersler_tbl`
--
ALTER TABLE `tlp_g_anadersler_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tlp_g_serbestler_tbl`
--
ALTER TABLE `tlp_g_serbestler_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tlp_nobetyeri_tbl`
--
ALTER TABLE `tlp_nobetyeri_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tlp_ogrencilistesi_tbl`
--
ALTER TABLE `tlp_ogrencilistesi_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tlp_ogretmenbilgileri_tbl`
--
ALTER TABLE `tlp_ogretmenbilgileri_tbl`
  ADD PRIMARY KEY (`oid`);

--
-- Tablo için indeksler `tlp_sosyalkulup_tbl`
--
ALTER TABLE `tlp_sosyalkulup_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tlp_y_anadersler_tbl`
--
ALTER TABLE `tlp_y_anadersler_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tlp_y_serbestler_tbl`
--
ALTER TABLE `tlp_y_serbestler_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tlp_zumreogretmenleri_tbl`
--
ALTER TABLE `tlp_zumreogretmenleri_tbl`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `odemeler_tbl`
--
ALTER TABLE `odemeler_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Tablo için AUTO_INCREMENT değeri `sis_anadersleroto_tbl`
--
ALTER TABLE `sis_anadersleroto_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Tablo için AUTO_INCREMENT değeri `sis_bayiler_tbl`
--
ALTER TABLE `sis_bayiler_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=534;
--
-- Tablo için AUTO_INCREMENT değeri `sis_branslar_tbl`
--
ALTER TABLE `sis_branslar_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
--
-- Tablo için AUTO_INCREMENT değeri `sis_defterler_tbl`
--
ALTER TABLE `sis_defterler_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;
--
-- Tablo için AUTO_INCREMENT değeri `sis_dersdagilim_gruplari`
--
ALTER TABLE `sis_dersdagilim_gruplari`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=236;
--
-- Tablo için AUTO_INCREMENT değeri `sis_excel_bilgisutunlari_tbl`
--
ALTER TABLE `sis_excel_bilgisutunlari_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Tablo için AUTO_INCREMENT değeri `sis_gunlukplandersler_tbl`
--
ALTER TABLE `sis_gunlukplandersler_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=90;
--
-- Tablo için AUTO_INCREMENT değeri `sis_ildersleri_tbl`
--
ALTER TABLE `sis_ildersleri_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=82;
--
-- Tablo için AUTO_INCREMENT değeri `sis_iller_tbl`
--
ALTER TABLE `sis_iller_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=82;
--
-- Tablo için AUTO_INCREMENT değeri `sis_ilyayinevino_tbl`
--
ALTER TABLE `sis_ilyayinevino_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=82;
--
-- Tablo için AUTO_INCREMENT değeri `sis_kurtulus_tbl`
--
ALTER TABLE `sis_kurtulus_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=148;
--
-- Tablo için AUTO_INCREMENT değeri `sis_mudurunvan_tbl`
--
ALTER TABLE `sis_mudurunvan_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- Tablo için AUTO_INCREMENT değeri `sis_nobetyerisablon_tbl`
--
ALTER TABLE `sis_nobetyerisablon_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- Tablo için AUTO_INCREMENT değeri `sis_odemeturu_tbl`
--
ALTER TABLE `sis_odemeturu_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- Tablo için AUTO_INCREMENT değeri `sis_serbestetkinlikderssaati_tbl`
--
ALTER TABLE `sis_serbestetkinlikderssaati_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Tablo için AUTO_INCREMENT değeri `sis_serbestetkinlikler_tbl`
--
ALTER TABLE `sis_serbestetkinlikler_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;
--
-- Tablo için AUTO_INCREMENT değeri `sis_siniflar_tbl`
--
ALTER TABLE `sis_siniflar_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- Tablo için AUTO_INCREMENT değeri `sis_sosyalkulupler_tbl`
--
ALTER TABLE `sis_sosyalkulupler_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;
--
-- Tablo için AUTO_INCREMENT değeri `sis_tumdersler_tbl`
--
ALTER TABLE `sis_tumdersler_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=251;
--
-- Tablo için AUTO_INCREMENT değeri `sis_varsayilanlar_tbl`
--
ALTER TABLE `sis_varsayilanlar_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Tablo için AUTO_INCREMENT değeri `sis_yillar_tbl`
--
ALTER TABLE `sis_yillar_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- Tablo için AUTO_INCREMENT değeri `tlp_defterler_tbl`
--
ALTER TABLE `tlp_defterler_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=839;
--
-- Tablo için AUTO_INCREMENT değeri `tlp_ekurunler_tbl`
--
ALTER TABLE `tlp_ekurunler_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Tablo için AUTO_INCREMENT değeri `tlp_g_anadersler_tbl`
--
ALTER TABLE `tlp_g_anadersler_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Tablo için AUTO_INCREMENT değeri `tlp_g_serbestler_tbl`
--
ALTER TABLE `tlp_g_serbestler_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Tablo için AUTO_INCREMENT değeri `tlp_nobetyeri_tbl`
--
ALTER TABLE `tlp_nobetyeri_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- Tablo için AUTO_INCREMENT değeri `tlp_ogrencilistesi_tbl`
--
ALTER TABLE `tlp_ogrencilistesi_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- Tablo için AUTO_INCREMENT değeri `tlp_ogretmenbilgileri_tbl`
--
ALTER TABLE `tlp_ogretmenbilgileri_tbl`
  MODIFY `oid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=839;
--
-- Tablo için AUTO_INCREMENT değeri `tlp_sosyalkulup_tbl`
--
ALTER TABLE `tlp_sosyalkulup_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Tablo için AUTO_INCREMENT değeri `tlp_y_anadersler_tbl`
--
ALTER TABLE `tlp_y_anadersler_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Tablo için AUTO_INCREMENT değeri `tlp_y_serbestler_tbl`
--
ALTER TABLE `tlp_y_serbestler_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Tablo için AUTO_INCREMENT değeri `tlp_zumreogretmenleri_tbl`
--
ALTER TABLE `tlp_zumreogretmenleri_tbl`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

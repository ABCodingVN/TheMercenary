import Styles from './Header.module.scss';
import { BsSearch } from 'react-icons/bs';
import { FaUserCircle } from 'react-icons/fa';
import { AiOutlineShoppingCart } from 'react-icons/ai';
import Logo from '../../Image/logo.png';
import Freeship from '../../Image/freeship.png';
import { Link } from 'react-router-dom';

export default function Header() {
    return (
        <div className={Styles.Header}>
            <div className={Styles.Logo}>
                <img src={Logo} alt="logo" />
                <img src={Freeship} alt="Freeship" />
            </div>
            <div className={Styles.Seaching}>
                <input type="text" />
                <BsSearch />
            </div>
            <div className={Styles.Login}>
                <FaUserCircle />
                <Link to="/login">
                    <p>Đăng nhập/Đăng ký</p>
                </Link>
            </div>
            <div className={Styles.Cart}>
                <AiOutlineShoppingCart /> <p> Giỏ hàng</p>
            </div>
        </div>
    );
}

import React from 'react'
import { Link } from 'react-router-dom'
import Styles from './CategoryItems.module.scss'


const listCategory = [
  {
    name: 'Điện tử',
    link: '/',
  },
  {
    name: 'Thiết bị số',
    link: '/',
  },
  {
    name: 'Điện thoại',
    link: '/',
  },
  {
    name: 'Mẹ và bé',
    link: '/',
  },
  {
    name: 'Làm đẹp',
    link: '/',
  },
  {
    name: 'Gia dụng',
    link: '/',
  },
  {
    name: 'Thời trang nữ',
    link: '/',
  },
  {
    name: 'Thời trang nam',
    link: '/',
  },
  {
    name: 'Giày nữ',
    link: '/',
  },
  {
    name: 'Giày nam ',
    link: '/',
  },
  {
    name: 'Túi nữ',
    link: '/',
  },
  {
    name: 'Balo vali',
    link: '/',
  },
  {
    name: 'Phụ kiện',
    link: '/',
  },
  {
    name: 'Đồng hồ',
    link: '/',
  },
  {
    name: 'Xe',
    link: '/',
  },
  {
    name: 'Sách',
    link: '/',
  },
]

export default function CategoryItems() {
  return (
    <div>
      <ul className={Styles.listCagerory}>
        {listCategory.map((item) => (
          <li key={item.name} className={Styles.itemCategory}>
            <Link to={item.link}>{item.name}</Link>
          </li>
        ))}
      </ul>
    </div>
  )
}

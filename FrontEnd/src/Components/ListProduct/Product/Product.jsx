import React from 'react'
import Styles from './Product.module.scss'

export default function Product(props) {
  const { ImageURL, Name, Price } = props
  return (
    <div className={Styles.Product}>
      <div className={Styles.imageProduct}>
        <img src={ImageURL} alt="thumbnail" />
      </div>
      <p className={Styles.Title}>{Name}</p>
      <div className={Styles.Price}>
        <p className={Styles.priceSale}> {Price} đ</p>
        <span className={Styles.Sale}>10%</span>
      </div>
    </div>
  )
}

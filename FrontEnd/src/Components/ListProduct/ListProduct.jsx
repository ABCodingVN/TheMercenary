import React, { useEffect, useState } from 'react'
import { getAllProduct } from './../../Api/Api'
import Styles from './ListProduct.module.scss'
import Product from './Product'

export default function ListProduct() {
  const [products, setProducts] = useState([])
  useEffect(() => {
    const fetch = async () => {
      const data = await getAllProduct()
      console.log(data)
      setProducts(data)
    }
    fetch()
  }, [])
  return (
    <div className={Styles.listProduct}>
      {products.length ? (
        products.map((item) => <Product key={item.thumbnail} {...item} />)
      ) : (
        <h2 className={Styles.notFoundItem}>No items</h2>
      )}
    </div>
  )
}

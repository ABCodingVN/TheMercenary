import React from 'react'
import { Banner, Header, CategoryItems, ListProduct, Footer } from '../../Components'

export default function Home() {
  return (
    <div>
      <Header />
      <CategoryItems />
      <Banner />
      <ListProduct />
      <Footer />
    </div>
  )
}

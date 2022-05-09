import React, { useEffect } from 'react'
import { LoginAPI } from '../../Api/Api'

export default function Login() {
  useEffect(() => {
    const fetch = async () => {
      const user = {
        PhoneNumber: '12345678',
        Password: 'string',
      }
      const token = await LoginAPI(user)
      if (token) {
        console.log(token)
      } else {
        console.log('Unauthor')
      }
    }
    fetch()
  }, [])
  return <div></div>
}
